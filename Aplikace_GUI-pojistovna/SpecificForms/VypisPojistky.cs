using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Aplikace_GUI_pojistovna.SpecificForms
{
    public partial class VypisPojistky : UserControl
    {
        private DatabaseConnection databaseConnection;

        public VypisPojistky()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
            PopulateComboBox(); // Populate the ComboBox with descriptive values
            LoadData(); // Load initial data into the DataGridView
        }

        // Method to populate the ComboBox with type mappings
        private void PopulateComboBox()
        {
            var types = new Dictionary<string, string>
            {
                { "p", "Připojištění" },
                { "m", "Pojištění Majetku" },
                { "u", "Úrazové Pojištění" }
            };

            comboBox1.DataSource = new BindingSource(types, null);
            comboBox1.DisplayMember = "Value"; // Display descriptive name
            comboBox1.ValueMember = "Key";    // Use single-letter code for filtering
            comboBox1.SelectedIndex = -1;     // No initial selection
        }

        // Load data into the DataGridView, with optional filtering
        private void LoadData(string filterColumn = null, string filterValue = null)
        {
            DataTable data;
            if (!string.IsNullOrEmpty(filterColumn) && !string.IsNullOrEmpty(filterValue))
            {
                data = databaseConnection.GetPojistky(filterColumn, filterValue); // Get filtered data
            }
            else
            {
                data = databaseConnection.GetDataFromView("POJISTKA"); // Get all data
            }
            dataGridViewVypisPojistky.DataSource = data;
        }

        // Event handler for the search button click
        private void newButtonHledatPojistku_Click(object sender, EventArgs e)
        {
            string filterValue = textBox1.Text; // Text entered by the user
            string filterColumn = GetSelectedFilterColumn();

            if (filterColumn == "POJ_ID_ARC" && comboBox1.SelectedValue != null)
            {
                // Use the selected ComboBox value for filtering
                filterValue = comboBox1.SelectedValue.ToString();
            }

            if (!string.IsNullOrEmpty(filterColumn) && !string.IsNullOrEmpty(filterValue))
            {
                LoadData(filterColumn, filterValue); // Apply filtering
            }
            else
            {
                MessageBox.Show("Please select a valid filter option or enter a value.");
            }
        }

        // Determine the selected filter column
        private string GetSelectedFilterColumn()
        {
            if (radioButton2_podlePoznamky.Checked) return "POJ_POZNAMKA"; // Filter by POJ_POZNAMKA
            if (comboBox1.SelectedValue != null) return "POJ_ID_ARC";     // Filter by POJ_ID_ARC
            return null;
        }

        // Reset filters and reload all data
        private void newButtonNULLFILTER_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1; // Reset ComboBox selection
            textBox1.Clear();            // Clear text box
            LoadData();                  // Reload all data
        }



        private void newButtonNULLFILTER_Click_2(object sender, EventArgs e)
        {
            // Reset the ComboBox selection
            comboBox1.SelectedIndex = -1;

            // Clear the TextBox input
            textBox1.Clear();

            // Reload all data from the database
            LoadData();

        }

        private void newButtonHledatPojistku_Click_1(object sender, EventArgs e)
        {
            newButtonHledatPojistku_Click(sender, e);
        }
    }
}
