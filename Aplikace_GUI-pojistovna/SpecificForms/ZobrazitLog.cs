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
    public partial class ZobrazitLog : UserControl
    {
        public ZobrazitLog()
        {
            InitializeComponent();
            LoadLog();
        }


        private void LoadLog()
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
                    SELECT TABULKA, OPERACE, CAS, UZIVATEL
                    FROM LOG_TABLE
                    ORDER BY CAS";
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();

                // Naplnění dat do DataTable
                adapter.Fill(dataTable);

                // Přiřazení DataTable jako zdroje dat pro DataGridView
                dataGridView1.DataSource = dataTable;

                // Zavření připojení
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání klientů: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
