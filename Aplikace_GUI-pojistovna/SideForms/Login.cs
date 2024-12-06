using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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

                // Inicializace připojení k databázi přes třídu DatabaseConnection
                DatabaseConnection databaseConnection = new DatabaseConnection();
                connection = databaseConnection.GetConnection();

                // Test připojení
                if (connection.State != ConnectionState.Open)
                {
                    await connection.OpenAsync();
                }

                // Získání přihlašovacích údajů z textových polí
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

                    object result = await command.ExecuteScalarAsync();
                    if (result != null && int.TryParse(result.ToString(), out int role))
                    {
                        // Přesměrování na odpovídající formulář podle role
                        switch (role)
                        {
                            case 2:
                                if (sideForm != null && mainForm != null)
                                {
                                    sideForm.ShowMainScreenRoleBased(1);
                                    mainForm.ShowSideScreenRoleBased(1);
                                }
                                break;
                            case 3:
                                if (sideForm != null && mainForm != null)
                                {
                                    sideForm.ShowMainScreenRoleBased(2);
                                    mainForm.ShowSideScreenRoleBased(2);
                                }
                                break;
                            case 4:
                                if (sideForm != null && mainForm != null)
                                {
                                    sideForm.ShowMainScreenRoleBased(3);
                                    mainForm.ShowSideScreenRoleBased(3);
                                }
                                break;
                            case 5:
                                if (sideForm != null && mainForm != null)
                                {
                                    sideForm.ShowMainScreenRoleBased(4);
                                    mainForm.ShowSideScreenRoleBased(4);
                                }
                                break;
                            case 6:
                                if (sideForm != null && mainForm != null)
                                {
                                    sideForm.ShowMainScreenRoleBased(5);
                                    mainForm.ShowSideScreenRoleBased(5);
                                }
                                break;
                            default:
                                MessageBox.Show("Neznámá role uživatele.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }
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


        private async Task<int> GetUserRoleAsync(string email, OracleConnection connection)
        {
            string query = "SELECT PERMISE_ID_PERMISE FROM Kontakt WHERE email = :email";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

                object result = await command.ExecuteScalarAsync();
                if (result is Oracle.ManagedDataAccess.Types.OracleDecimal oracleDecimalResult)
                {
                    return oracleDecimalResult.ToInt32(); // Převod OracleDecimal na int
                }
                return 0; // Pokud není nalezena role
            }
        }








    }
}
