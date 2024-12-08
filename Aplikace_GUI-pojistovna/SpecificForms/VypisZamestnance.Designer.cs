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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            newButtonNULLFILTER = new NewButton();
            textBox3 = new TextBox();
            newButtonHledatZamestnance = new NewButton();
            dataGridViewVypisZamestnance = new DataGridView();
            radioButton1_podleJmena = new RadioButton();
            radioButton2_podle2Jmena = new RadioButton();
            radioButton3_podlePrijmeni = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVypisZamestnance).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewVypisZamestnance, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(900, 523);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(newButtonHledatZamestnance, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(894, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(textBox3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(709, 66);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(radioButton3_podlePrijmeni, 0, 0);
            tableLayoutPanel5.Controls.Add(radioButton2_podle2Jmena, 0, 0);
            tableLayoutPanel5.Controls.Add(radioButton1_podleJmena, 0, 0);
            tableLayoutPanel5.Controls.Add(newButtonNULLFILTER, 4, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 36);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(703, 27);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // newButtonNULLFILTER
            // 
            newButtonNULLFILTER.BackColor = Color.LightCoral;
            newButtonNULLFILTER.BackgroundColor = Color.LightCoral;
            newButtonNULLFILTER.BorderColor = Color.PaleVioletRed;
            newButtonNULLFILTER.BorderRadius = 0;
            newButtonNULLFILTER.BorderSize = 0;
            newButtonNULLFILTER.Dock = DockStyle.Fill;
            newButtonNULLFILTER.FlatAppearance.BorderSize = 0;
            newButtonNULLFILTER.FlatStyle = FlatStyle.Flat;
            newButtonNULLFILTER.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 238);
            newButtonNULLFILTER.ForeColor = Color.White;
            newButtonNULLFILTER.Location = new Point(563, 3);
            newButtonNULLFILTER.Name = "newButtonNULLFILTER";
            newButtonNULLFILTER.Size = new Size(137, 21);
            newButtonNULLFILTER.TabIndex = 3;
            newButtonNULLFILTER.Text = "vynulovat filtr";
            newButtonNULLFILTER.TextColor = Color.White;
            newButtonNULLFILTER.UseVisualStyleBackColor = false;
            newButtonNULLFILTER.Click += newButtonNULLFILTER_Click;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(703, 27);
            textBox3.TabIndex = 0;
            // 
            // newButtonHledatZamestnance
            // 
            newButtonHledatZamestnance.BackColor = Color.MediumSlateBlue;
            newButtonHledatZamestnance.BackgroundColor = Color.MediumSlateBlue;
            newButtonHledatZamestnance.BorderColor = Color.PaleVioletRed;
            newButtonHledatZamestnance.BorderRadius = 0;
            newButtonHledatZamestnance.BorderSize = 0;
            newButtonHledatZamestnance.Dock = DockStyle.Fill;
            newButtonHledatZamestnance.FlatAppearance.BorderSize = 0;
            newButtonHledatZamestnance.FlatStyle = FlatStyle.Flat;
            newButtonHledatZamestnance.ForeColor = Color.White;
            newButtonHledatZamestnance.Location = new Point(718, 3);
            newButtonHledatZamestnance.Name = "newButtonHledatZamestnance";
            newButtonHledatZamestnance.Size = new Size(173, 66);
            newButtonHledatZamestnance.TabIndex = 1;
            newButtonHledatZamestnance.Text = "Hledat Zamestannce";
            newButtonHledatZamestnance.TextColor = Color.White;
            newButtonHledatZamestnance.UseVisualStyleBackColor = false;
            newButtonHledatZamestnance.Click += newButtonHledatZamestnance_Click;
            // 
            // dataGridViewVypisZamestnance
            // 
            dataGridViewVypisZamestnance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVypisZamestnance.Dock = DockStyle.Fill;
            dataGridViewVypisZamestnance.Location = new Point(3, 81);
            dataGridViewVypisZamestnance.Name = "dataGridViewVypisZamestnance";
            dataGridViewVypisZamestnance.RowHeadersWidth = 51;
            dataGridViewVypisZamestnance.Size = new Size(894, 439);
            dataGridViewVypisZamestnance.TabIndex = 1;
            dataGridViewVypisZamestnance.CellContentClick += dataGridViewVypisZamestnance_CellContentClick;
            // 
            // radioButton1_podleJmena
            // 
            radioButton1_podleJmena.AutoSize = true;
            radioButton1_podleJmena.Location = new Point(3, 3);
            radioButton1_podleJmena.Name = "radioButton1_podleJmena";
            radioButton1_podleJmena.Size = new Size(112, 21);
            radioButton1_podleJmena.TabIndex = 5;
            radioButton1_podleJmena.TabStop = true;
            radioButton1_podleJmena.Text = "Podle jména";
            radioButton1_podleJmena.UseVisualStyleBackColor = true;
            // 
            // radioButton2_podle2Jmena
            // 
            radioButton2_podle2Jmena.AutoSize = true;
            radioButton2_podle2Jmena.Location = new Point(143, 3);
            radioButton2_podle2Jmena.Name = "radioButton2_podle2Jmena";
            radioButton2_podle2Jmena.Size = new Size(124, 21);
            radioButton2_podle2Jmena.TabIndex = 6;
            radioButton2_podle2Jmena.TabStop = true;
            radioButton2_podle2Jmena.Text = "Podle 2 jména";
            radioButton2_podle2Jmena.UseVisualStyleBackColor = true;
            // 
            // radioButton3_podlePrijmeni
            // 
            radioButton3_podlePrijmeni.AutoSize = true;
            radioButton3_podlePrijmeni.Location = new Point(283, 3);
            radioButton3_podlePrijmeni.Name = "radioButton3_podlePrijmeni";
            radioButton3_podlePrijmeni.Size = new Size(126, 21);
            radioButton3_podlePrijmeni.TabIndex = 7;
            radioButton3_podlePrijmeni.TabStop = true;
            radioButton3_podlePrijmeni.Text = "Podle příjmení";
            radioButton3_podlePrijmeni.UseVisualStyleBackColor = true;
            // 
            // VypisZamestnance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VypisZamestnance";
            Size = new Size(900, 523);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVypisZamestnance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private NewButton newButtonNULLFILTER;
        private TextBox textBox3;
        private NewButton newButtonHledatZamestnance;
        private DataGridView dataGridViewVypisZamestnance;
        private RadioButton radioButton1_podleJmena;
        private RadioButton radioButton2_podle2Jmena;
        private RadioButton radioButton3_podlePrijmeni;
    }
}
