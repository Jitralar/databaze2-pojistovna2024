namespace Aplikace_GUI_pojistovna.SpecificForms
{
    partial class VypisKlienty
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewKlienti = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKlienti).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewKlienti
            // 
            dataGridViewKlienti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKlienti.Location = new Point(-3, 0);
            dataGridViewKlienti.Name = "dataGridViewKlienti";
            dataGridViewKlienti.RowHeadersWidth = 51;
            dataGridViewKlienti.Size = new Size(903, 523);
            dataGridViewKlienti.TabIndex = 0;
            dataGridViewKlienti.CellContentClick += dataGridViewKlienti_CellContentClick;
            // 
            // VypisKlienty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewKlienti);
            Name = "VypisKlienty";
            Size = new Size(900, 523);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKlienti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewKlienti;
    }
}
