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
    public partial class StatistikyZamestnancu : UserControl
    {
        public StatistikyZamestnancu()
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
                var dataPlat = dbConnection.GetDataFromView("PRUMERNY_PLAT_ZAMESTNANCU");
                var dataPocetZam = dbConnection.GetDataFromView("POCET_ZAMESTNANCU_POZICE");
                var datakraj = dbConnection.GetDataFromView("POCET_ZAMESTNANCU_PODLE_KRAJE");

                // Přiřazení dat do DataGridView
                dataGridView_stats_rozdeleni_klientu_kraj.DataSource = dataPlat;
                dataGridView_stats_pocet_klientu_typ_pojistky.DataSource = dataPocetZam;
                dataGridView_stats_pocet_klientu_rok_sjednani.DataSource = datakraj;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání dat: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

