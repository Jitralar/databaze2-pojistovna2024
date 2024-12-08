using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikace_GUI_pojistovna.SpecificForms
{
    public partial class VypisZamestnance : UserControl
    {
        public VypisZamestnance()
        {
            InitializeComponent();
            LoadZamestnanci(); // Načtení zaměstnanců při spuštění
        }

        // Načtení dat zaměstnanců do DataGridView
        private void LoadZamestnanci()
        {
            try
            {
                // Připojení k databázi
                DatabaseConnection databaseConnection = new DatabaseConnection();
                OracleConnection connection = databaseConnection.GetConnection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // SQL dotaz pro získání údajů o zaměstnancích
                string query = @"
                    SELECT z.JMENO, z.DRUHE_JMENO, z.PRIJMENI, k.EMAIL, k.TELEFON, k.MOBIL, z.POZICE_ID_POZICE
                    FROM zamestnanec z
                    JOIN kontakt k ON z.KONTAKT_ID_KONTAKT = k.ID_KONTAKT";
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();

                // Naplnění dat do DataTable
                adapter.Fill(dataTable);

                // Přiřazení DataTable jako zdroje dat pro DataGridView
                dataGridViewVypisZamestnance.DataSource = dataTable;

                // Zavření připojení
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání zaměstnanců: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Událost pro kliknutí na buňku
        private void dataGridViewVypisZamestnance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Získání dat z vybrané řádky
            DataGridViewRow selectedRow = dataGridViewVypisZamestnance.Rows[e.RowIndex];
            string jmeno = selectedRow.Cells["JMENO"].Value.ToString();
            string druheJmeno = selectedRow.Cells["DRUHE_JMENO"].Value.ToString();
            string prijmeni = selectedRow.Cells["PRIJMENI"].Value.ToString();
            string email = selectedRow.Cells["EMAIL"].Value.ToString();
            string telefon = selectedRow.Cells["TELEFON"].Value.ToString();
            string mobil = selectedRow.Cells["MOBIL"].Value.ToString();
            string pozice = selectedRow.Cells["POZICE_ID_POZICE"].Value.ToString();

            // Zobrazení detailů zaměstnanců (např. MessageBox nebo TextBoxy)
            MessageBox.Show($"Jméno: {jmeno}\nDruhé jméno: {druheJmeno}\nPříjmení: {prijmeni}\nEmail: {email}\nTelefon: {telefon}\nMobil: {mobil}\nPozice: {pozice}",
                "Detaily zaměstnance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void newButtonHledatZamestnance_Click(object sender, EventArgs e)
        {
            string filterText = textBox3.Text.Trim();
            string filterColumn = "";

            if (radioButton1_podleJmena.Checked)
                filterColumn = "JMENO";
            else if (radioButton2_podle2Jmena.Checked)
                filterColumn = "DRUHE_JMENO"; // Pokud máš sloupec druhého jména v DB
            else if (radioButton3_podlePrijmeni.Checked)
                filterColumn = "PRIJMENI";

            if (!string.IsNullOrEmpty(filterText) && !string.IsNullOrEmpty(filterColumn))
            {
                ApplyFilter(filterColumn, filterText);
            }
            else
            {
                MessageBox.Show("Vyberte kritérium vyhledávání a zadejte text.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ApplyFilter(string column, string value)
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                OracleConnection connection = databaseConnection.GetConnection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // SQL dotaz s filtrem
                string query = $@"
            SELECT z.JMENO, z.PRIJMENI, c.EMAIL, c.TELEFON, c.MOBIL, z.POZICE_ID_POZICE
            FROM zamestnanec z
            JOIN kontakt c ON z.KONTAKT_ID_KONTAKT = c.ID_KONTAKT
            WHERE UPPER({column}) LIKE '%' || :value || '%'";

                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter("value", value.ToUpper())); // Parametr pro prevenci SQL injection
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();

                // Naplnění DataTable filtrováním
                adapter.Fill(dataTable);
                dataGridViewVypisZamestnance.DataSource = dataTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při aplikaci filtru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void newButtonNULLFILTER_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            radioButton1_podleJmena.Checked = false;
            radioButton2_podle2Jmena.Checked = false;
            radioButton3_podlePrijmeni.Checked = false;

            // Načti původní data
            LoadZamestnanci();
        }




    }
}
