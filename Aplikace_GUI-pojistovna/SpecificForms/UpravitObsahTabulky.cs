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
    public partial class UpravitObsahTabulky : UserControl
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public UpravitObsahTabulky()
        {
            InitializeComponent();
            LoadComboBox();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            

        }

        private void LoadComboBox()
        {
            string[] tableNames = {
                "Kategorie_Majetek",
                "KONTAKT",
                "Majetkove_Pojisteni",
                "Permise",
                "Pohledavka",
                "Pojistka",
                "Povinnosti",
                "Pozice",
                "Pripojisteni",
                "Secret",
                "Urazove_Pojisteni",
                "Zamestnanec_Pobocka",
                "Zamestnanec_Pojistka",
                "Zavazek"
            };
            comboBox1.Items.AddRange(tableNames);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedTable))
            {
                LoadDataToDataGridView(selectedTable);
            }
        }

        private void LoadDataToDataGridView(string tableName)
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                DataTable data = dbConnection.GetDataFromView(tableName);

                if (data != null)
                {
                    dataGridView1.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání dat z tabulky {tableName}: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
