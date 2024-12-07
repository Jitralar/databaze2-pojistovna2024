namespace Aplikace_GUI_pojistovna.SpecificForms
{
    partial class VypisZamestnance
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
            dataGridViewZamestnanci = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamestnanci).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewZamestnanci
            // 
            dataGridViewZamestnanci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZamestnanci.Location = new Point(0, -3);
            dataGridViewZamestnanci.Name = "dataGridViewZamestnanci";
            dataGridViewZamestnanci.RowHeadersWidth = 51;
            dataGridViewZamestnanci.Size = new Size(900, 526);
            dataGridViewZamestnanci.TabIndex = 0;
            dataGridViewZamestnanci.CellContentClick += dataGridViewZamestnanci_CellContentClick;
            // 
            // VypisZamestnance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewZamestnanci);
            Name = "VypisZamestnance";
            Size = new Size(900, 523);
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamestnanci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewZamestnanci;
    }
}
