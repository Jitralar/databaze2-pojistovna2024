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
    public partial class StatistikyPojistek : UserControl
    {
        public StatistikyPojistek()
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
                var dataKraje = dbConnection.GetDataFromView("AKTIVNI_POJISTKY_S_KLIENTY");
                var dataPojisteni = dbConnection.GetDataFromView("STATS_PRUMERNA_CENA_TYP_POJISTKY");
                var dataRoky = dbConnection.GetDataFromView("STATS_POCET_KLIENTU_TYP_POJISTKY");

                // Přiřazení dat do DataGridView
                dataGridView_stats_rozdeleni_klientu_kraj.DataSource = dataKraje;
                dataGridView_stats_pocet_klientu_typ_pojistky.DataSource = dataPojisteni;
                dataGridView_stats_pocet_klientu_rok_sjednani.DataSource = dataRoky;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při načítání dat: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}


