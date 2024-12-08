using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using static Aplikace_GUI_pojistovna.User;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Aplikace_GUI_pojistovna.SideForms
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void newButton2_Click(object sender, EventArgs e)
        {
            OracleConnection connection = null;
            try
            {
                var sideForm = this.FindForm() as Form1;
                var mainForm = this.FindForm() as Form1;

                // Inicializace připojení k databázi
                DatabaseConnection databaseConnection = new DatabaseConnection();
                connection = databaseConnection.GetConnection();

                if (connection.State != ConnectionState.Open)
                {
                    await connection.OpenAsync();
                }

                // Získání přihlašovacích údajů
                string email = textBox2.Text.Trim();
                string inputPassword = textBox1.Text.Trim();

                // PL/SQL příkaz pro ověření přihlašovacích údajů
                string functionName = "validate_user";
                bool isValidUser = await ExecuteStoredValidateLoginFunctionAsync(functionName, email, inputPassword, connection);

                if (isValidUser)
                {
                    // SQL dotaz pro získání role uživatele
                    string query = @"
                        SELECT p.id_permise 
                        FROM permise p
                        JOIN kontakt k ON p.id_permise = k.permise_id_permise
                        WHERE k.email = :email";

                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter(":email", email));


                    // SQL dotaz pro zápis do logu
                    string logQuery = @"
                        INSERT INTO LOG_TABLE (TABULKA, OPERACE, CAS, UZIVATEL, REPORT_HLASKA)
                        VALUES('LOG_TABLE', 'LOGED IN', SYSTIMESTAMP, 'ST67053', 'Uživatel :email se přihlásil do systému.')";
                    OracleCommand logQuery1 = new OracleCommand(logQuery, connection);
                    logQuery1.Parameters.Add(new OracleParameter(":email", email));
                    await logQuery1.ExecuteNonQueryAsync();



                    object result = await command.ExecuteScalarAsync();
                    if (result != null && int.TryParse(result.ToString(), out int role))
                    {
                        // Uložení aktuálního uživatele do statické třídy CurrentUser
                        CurrentUser.Email = email;
                        CurrentUser.Role = role;
                        CurrentUser.FullName = await GetFullNameAsync(email, connection);  // Získání jména uživatele

                        // Přesměrování na odpovídající formulář podle role
                        switch (CurrentUser.Role)
                        {
                            case 2:
                                sideForm.ShowMainScreenRoleBased(1);
                                mainForm.ShowSideScreenRoleBased(1);
                                break;
                            case 3:
                                sideForm.ShowMainScreenRoleBased(2);
                                mainForm.ShowSideScreenRoleBased(2);
                                break;
                            case 4:
                                sideForm.ShowMainScreenRoleBased(3);
                                mainForm.ShowSideScreenRoleBased(3);
                                break;
                            case 5:
                                sideForm.ShowMainScreenRoleBased(4);
                                mainForm.ShowSideScreenRoleBased(4);
                                break;
                            case 6:
                                sideForm.ShowMainScreenRoleBased(5);
                                mainForm.ShowSideScreenRoleBased(5);
                                break;
                            default:
                                MessageBox.Show("Neznámá role uživatele.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }

                        // Aktualizace labelů
                        UpdateLabels(mainForm, CurrentUser.FullName);

                        ClearLoginFields();
                    }
                    else
                    {
                        MessageBox.Show("Neznámá role uživatele.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Neplatné přihlašovací údaje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isValidUser)
                {
                     mainForm.SetCurrentUserEmail(email); // Uložení e-mailu

                }
                






            }
            catch (OracleException ex)
            {
                MessageBox.Show("Chyba při připojení k databázi: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neočekávaná chyba: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Uzavření připojení
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Funkce pro vymazání textových polí
        public void ClearLoginFields()
        {
            textBox1.Clear(); // Vymaže heslo
            textBox2.Clear(); // Vymaže email
        }

        // Funkce pro ověření přihlašovacích údajů
        private async Task<bool> ExecuteStoredValidateLoginFunctionAsync(string functionName, string email, string password, OracleConnection connection)
        {
            using (OracleCommand command = new OracleCommand(null, connection))
            {
                command.CommandText = $"BEGIN :result := {functionName}(:p_email, :p_password); END;";

                // Nastavení parametrů
                command.Parameters.Add("result", OracleDbType.Decimal, ParameterDirection.ReturnValue); // Změněno na Decimal
                command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = email;
                command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                await command.ExecuteNonQueryAsync();

                // Explicitní převod z OracleDecimal na int
                var oracleDecimalResult = (Oracle.ManagedDataAccess.Types.OracleDecimal)command.Parameters["result"].Value;
                int validationResult = oracleDecimalResult.ToInt32();

                return validationResult == 1;
            }
        }

        // Funkce pro zobrazení celého jména uživatele
        public async Task<string> GetFullNameAsync(string email, OracleConnection connection)
        {
            const string query = @"
                SELECT 
                    k.jmeno || 
                    CASE WHEN k.druhe_jmeno IS NULL THEN ' ' || k.druhe_jmeno ELSE '' END || 
                    ' ' || k.prijmeni AS full_name
                FROM 
                    kontakt c
                JOIN 
                    klient k ON c.id_kontakt = k.kontakt_id_kontakt
                WHERE 
                    c.email = :email
                UNION
                SELECT 
                    z.jmeno || 
                    CASE WHEN z.druhe_jmeno IS NULL THEN ' ' || z.druhe_jmeno ELSE '' END || 
                    ' ' || z.prijmeni AS full_name
                FROM 
                    kontakt c
                JOIN 
                    zamestnanec z ON c.id_kontakt = z.kontakt_id_kontakt
                WHERE 
                    c.email = :email";

            try
            {
                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

                    // Spuštění dotazu
                    var result = await command.ExecuteScalarAsync();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Dotaz nevrátil žádná data.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return "Neznámý uživatel";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při vykonávání dotazu: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Chyba";
            }
        }

        // Funkce pro aktualizaci Labelů
        private void UpdateLabels(Form1 mainForm, string userName)
        {
            if (mainForm != null)
            {
                // Seznam všech labelů, které je potřeba aktualizovat
                var labels = new string[] { "r2label", "r3label", "r4label", "r5label", "r6label" };

                foreach (var labelName in labels)
                {
                    var label = mainForm.Controls.Find(labelName, true).FirstOrDefault() as Label;
                    if (label != null)
                    {
                        label.Text = $"Přihlášen jako uživatel:\n {userName}";
                        label.Visible = true; // Zajistí, že je label viditelný
                    }
                }
            }
        }
    }
}
