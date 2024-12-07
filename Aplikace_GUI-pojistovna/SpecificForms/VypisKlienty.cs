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
    public partial class VypisKlienty : UserControl
    {
        public VypisKlienty()
        {
            InitializeComponent();
            LoadKlienti(); // Načtení klientů při spuštění
        }

        // Načtení dat klientů do DataGridView
        private void LoadKlienti()
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

                // Dotaz na klienty a jejich kontaktní údaje
                string query = @"
                    SELECT k.JMENO, k.PRIJMENI, c.EMAIL, c.TELEFON, c.MOBIL, k.PRIJEM
                    FROM klient k
                    JOIN kontakt c ON k.KONTAKT_ID_KONTAKT = c.ID_KONTAKT";
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();

                // Naplnění dat do DataTable
                adapter.Fill(dataTable);

                // Přiřazení DataTable jako zdroje dat pro DataGridView
                dataGridViewKlienti.DataSource = dataTable;

                // Zavření připojení
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání klientů: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Událost pro kliknutí na buňku
        private void dataGridViewKlienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Získání dat z vybrané řádky
            DataGridViewRow selectedRow = dataGridViewKlienti.Rows[e.RowIndex];
            string jmeno = selectedRow.Cells["JMENO"].Value.ToString();
            string prijmeni = selectedRow.Cells["PRIJMENI"].Value.ToString();
            string email = selectedRow.Cells["EMAIL"].Value.ToString();
            string telefon = selectedRow.Cells["TELEFON"].Value.ToString();
            string mobil = selectedRow.Cells["MOBIL"].Value.ToString();
            string prijem = selectedRow.Cells["PRIJEM"].Value.ToString();

            // Zobrazení detailů klienta (např. MessageBox nebo TextBoxy)
            MessageBox.Show($"Jméno: {jmeno}\nPříjmení: {prijmeni}\nEmail: {email}\nTelefon: {telefon}\nMobil: {mobil}\nPříjem: {prijem}",
                "Detaily klienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
