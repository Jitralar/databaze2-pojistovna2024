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
    public partial class StatistikyPobocek : UserControl
    {
        public StatistikyPobocek()
        {
            InitializeComponent();
            NaplnDataGridy();
        }

        private void NaplnDataGridy()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            {
                // Načíst data z pohledů
                var dataKraje = dbConnection.GetDataFromView("ZAMESTNANCI_POBOCKY");
                var dataPojisteni = dbConnection.GetDataFromView("STATS_POBOCKY_POCET_V_KRAJI");
                var dataRoky = dbConnection.GetDataFromView("nazvy_pobociek");

                // Přiřazení dat do DataGridView
                dataGridView3.DataSource = dataKraje;
                dataGridView2.DataSource = dataPojisteni;
                dataGridView1.DataSource = dataRoky;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání dat: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

