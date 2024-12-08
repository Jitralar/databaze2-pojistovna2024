using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Aplikace_GUI_pojistovna.MainForms
{
    public partial class UserProfil : UserControl
    {
        public UserProfil()
        {
            InitializeComponent();
            PopulateComboboxKraje();
        }

        public async void LoadUserData(string email)
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                int role = databaseConnection.GetUserRole(email); // Získání role uživatele
                DataTable userData = databaseConnection.GetUserProfile(email, role);

                if (userData.Rows.Count > 0)
                {
                    DataRow row = userData.Rows[0];

                    // Nastavení hodnot do TextBox
                    textBox15.Text = row.Table.Columns.Contains("JMENO") ? row["JMENO"]?.ToString() : string.Empty;
                    textBox13.Text = row.Table.Columns.Contains("DRUHE_JMENO") ? row["DRUHE_JMENO"]?.ToString() : string.Empty;
                    textBox12.Text = row.Table.Columns.Contains("PRIJMENI") ? row["PRIJMENI"]?.ToString() : string.Empty;

                    // Nastavení hodnoty do DateTimePicker
                    if (row.Table.Columns.Contains("DATUM_NAROZENI") && row["DATUM_NAROZENI"] != DBNull.Value &&
                        DateTime.TryParse(row["DATUM_NAROZENI"].ToString(), out DateTime parsedDate))
                    {
                        dateTimePicker1.Value = parsedDate;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now; // Výchozí hodnota
                    }

                    // Nastavení hodnoty do ComboBox
                    if (row.Table.Columns.Contains("KRAJ"))
                    {
                        string kraj = row["KRAJ"]?.ToString();
                        if (comboBox1Kraj.Items.Contains(kraj))
                        {
                            comboBox1Kraj.SelectedItem = kraj; // Pokud hodnota existuje, nastavíme ji
                        }
                        else
                        {
                            comboBox1Kraj.SelectedIndex = -1; // Pokud hodnota neexistuje, vymažeme výběr
                        }
                    }
                    else
                    {
                        comboBox1Kraj.SelectedIndex = -1; // Výchozí hodnota
                    }

                    // Nastavení dalších TextBox
                    textBox1Ulice.Text = row.Table.Columns.Contains("ULICE") ? row["ULICE"]?.ToString() : string.Empty;
                    textBoxMesto.Text = row.Table.Columns.Contains("MESTO") ? row["MESTO"]?.ToString() : string.Empty;
                    textBox6PSC.Text = row.Table.Columns.Contains("PSC") ? row["PSC"]?.ToString() : string.Empty;
                    textBox8.Text = row.Table.Columns.Contains("TELEFON") ? row["TELEFON"]?.ToString() : string.Empty;
                    textBox7.Text = row.Table.Columns.Contains("MOBIL") ? row["MOBIL"]?.ToString() : string.Empty;
                    textBox1.Text = row.Table.Columns.Contains("EMAIL") ? row["EMAIL"]?.ToString() : string.Empty;
                }
                else
                {
                    MessageBox.Show("Data uživatele nebyla nalezena.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání dat uživatele: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateComboboxKraje()
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                OracleConnection connection = databaseConnection.GetConnection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT DISTINCT nazev_kraje FROM kraj";
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataReader reader = command.ExecuteReader();

                comboBox1Kraj.Items.Clear(); // Vymazání starých položek

                while (reader.Read())
                {
                    string kraj = reader.GetString(0);
                    if (!comboBox1Kraj.Items.Contains(kraj))
                    {
                        comboBox1Kraj.Items.Add(kraj);
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání krajů: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
