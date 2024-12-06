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
            // Získání přihlašovacích údajů z textových polí
            string email = textBox2.Text; // Uživatelské jméno (e-mail)
            string password = textBox1.Text; // Heslo

            var sideForm = this.FindForm() as Form1;
            var mainForm = this.FindForm() as Form1;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("E-mail a heslo jsou povinné!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Inicializace připojení k databázi přes třídu DatabaseConnection
                DatabaseConnection databaseConnection = new DatabaseConnection();
                using (OracleConnection connection = databaseConnection.GetConnection())
                {
                    await connection.OpenAsync();

                    // Ověření přihlašovacích údajů pomocí PL/SQL funkce
                    bool isValidUser = await ExecuteStoredValidateLoginFunctionAsync("validate_user", email, password, connection);

                    if (isValidUser)
                    {
                        // Získání role uživatele
                        int userRole = await GetUserRoleAsync(email, connection);

                        // Přesměrování na odpovídající formulář podle role
                        this.ParentForm.Hide();
                        switch (userRole)
                        {
                            case 2:
                                
                                if (sideForm != null || mainForm != null)
                                {
                                    // Zavolej metodu pro zobrazení Role2
                                    sideForm.ShowMainScreenRoleBased(2);
                                    mainForm.ShowSideScreenRoleBased(2);
                                }
                                break;
                            case 3:
                                
                                if (sideForm != null || mainForm != null)
                                {
                                    // Zavolej metodu pro zobrazení Role3
                                    sideForm.ShowMainScreenRoleBased(3);
                                    mainForm.ShowSideScreenRoleBased(3);
                                }
                                break;
                            case 4:
                                if (sideForm != null || mainForm != null)
                                {
                                    // Zavolej metodu pro zobrazení Role4
                                    sideForm.ShowMainScreenRoleBased(4);
                                    mainForm.ShowSideScreenRoleBased(4);
                                }
                                break;
                            case 5:
                                if (sideForm != null || mainForm != null)
                                {
                                    // Zavolej metodu pro zobrazení Role5
                                    sideForm.ShowMainScreenRoleBased(5);
                                    mainForm.ShowSideScreenRoleBased(5);
                                }
                                break;
                            case 6:
                                if (sideForm != null || mainForm != null)
                                {
                                    // Zavolej metodu pro zobrazení Role6
                                    sideForm.ShowMainScreenRoleBased(6);
                                    mainForm.ShowSideScreenRoleBased(6);
                                }
                                break;                 
                            default:
                                MessageBox.Show("Neznámá role uživatele.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.ParentForm.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Neplatné přihlašovací údaje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při připojení nebo ověřování: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> ExecuteStoredValidateLoginFunctionAsync(string functionName, string email, string password, OracleConnection connection)
        {
            using (OracleCommand command = new OracleCommand(null, connection))
            {
                command.CommandText = $"BEGIN :result := {functionName}(:p_email, :p_password); END;";

                command.Parameters.Add("result", OracleDbType.Int32, ParameterDirection.ReturnValue);
                command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = email;
                command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                await command.ExecuteNonQueryAsync();

                int validationResult = Convert.ToInt32(command.Parameters["result"].Value);
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
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }







    }
}
