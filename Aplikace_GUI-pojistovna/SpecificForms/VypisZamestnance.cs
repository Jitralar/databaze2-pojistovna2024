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
                dataGridViewZamestnanci.DataSource = dataTable;

                // Zavření připojení
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání zaměstnanců: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Událost pro kliknutí na buňku
        private void dataGridViewZamestnanci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Získání dat z vybrané řádky
            DataGridViewRow selectedRow = dataGridViewZamestnanci.Rows[e.RowIndex];
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
    }
}
