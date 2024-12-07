using System;
using System.Data;
using System.Windows.Forms;



namespace Aplikace_GUI_pojistovna.SpecificForms
{
    public partial class StatistikyKlientu : UserControl
    {
        public StatistikyKlientu()
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
                var dataKraje = dbConnection.GetDataFromView("stats_rozdeleni_klientu_kraj");
                var dataPojisteni = dbConnection.GetDataFromView("stats_pocet_klientu_typ_pojistky");
                var dataRoky = dbConnection.GetDataFromView("stats_pocet_klientu_rok_sjednani");

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
