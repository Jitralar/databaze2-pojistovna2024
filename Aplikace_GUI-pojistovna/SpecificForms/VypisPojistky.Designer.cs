namespace Aplikace_GUI_pojistovna.SpecificForms
{
    partial class VypisPojistky
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
            comboBox1 = new ComboBox();
            radioButton2_podlePoznamky = new RadioButton();
            radioButton1 = new RadioButton();
            newButtonNULLFILTER = new NewButton();
            textBox1 = new TextBox();
            dataGridViewVypisPojistky = new DataGridView();
            newButtonHledatPojistku = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVypisPojistky).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewVypisPojistky, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(900, 523);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(newButtonHledatPojistku, 1, 0);
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
            tableLayoutPanel3.Controls.Add(textBox1, 0, 0);
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
            tableLayoutPanel5.Controls.Add(comboBox1, 2, 0);
            tableLayoutPanel5.Controls.Add(radioButton2_podlePoznamky, 1, 0);
            tableLayoutPanel5.Controls.Add(radioButton1, 0, 0);
            tableLayoutPanel5.Controls.Add(newButtonNULLFILTER, 4, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 36);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(703, 27);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Připojištění (p)", "Pojištění Majetku (m)", "Úrazové Pojištění (u)" });
            comboBox1.Location = new Point(283, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Podle typu";
            // 
            // radioButton2_podlePoznamky
            // 
            radioButton2_podlePoznamky.AutoSize = true;
            radioButton2_podlePoznamky.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButton2_podlePoznamky.Location = new Point(143, 3);
            radioButton2_podlePoznamky.Name = "radioButton2_podlePoznamky";
            radioButton2_podlePoznamky.Size = new Size(125, 21);
            radioButton2_podlePoznamky.TabIndex = 0;
            radioButton2_podlePoznamky.TabStop = true;
            radioButton2_podlePoznamky.Text = "Podle poznámky";
            radioButton2_podlePoznamky.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 21);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Podle Uživatele";
            radioButton1.UseVisualStyleBackColor = true;
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
            newButtonNULLFILTER.TabIndex = 6;
            newButtonNULLFILTER.Text = "vynulovat filtr";
            newButtonNULLFILTER.TextColor = Color.White;
            newButtonNULLFILTER.UseVisualStyleBackColor = false;
            newButtonNULLFILTER.Click += newButtonNULLFILTER_Click_2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(703, 27);
            textBox1.TabIndex = 0;
            // 
            // dataGridViewVypisPojistky
            // 
            dataGridViewVypisPojistky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVypisPojistky.Dock = DockStyle.Fill;
            dataGridViewVypisPojistky.Location = new Point(3, 81);
            dataGridViewVypisPojistky.Name = "dataGridViewVypisPojistky";
            dataGridViewVypisPojistky.RowHeadersWidth = 51;
            dataGridViewVypisPojistky.Size = new Size(894, 439);
            dataGridViewVypisPojistky.TabIndex = 1;
            // 
            // newButtonHledatPojistku
            // 
            newButtonHledatPojistku.BackColor = Color.MediumSlateBlue;
            newButtonHledatPojistku.BackgroundColor = Color.MediumSlateBlue;
            newButtonHledatPojistku.BorderColor = Color.PaleVioletRed;
            newButtonHledatPojistku.BorderRadius = 0;
            newButtonHledatPojistku.BorderSize = 0;
            newButtonHledatPojistku.Dock = DockStyle.Fill;
            newButtonHledatPojistku.FlatAppearance.BorderSize = 0;
            newButtonHledatPojistku.FlatStyle = FlatStyle.Flat;
            newButtonHledatPojistku.ForeColor = Color.White;
            newButtonHledatPojistku.Location = new Point(718, 3);
            newButtonHledatPojistku.Name = "newButtonHledatPojistku";
            newButtonHledatPojistku.Size = new Size(173, 66);
            newButtonHledatPojistku.TabIndex = 1;
            newButtonHledatPojistku.Text = "Hledat Pojistku";
            newButtonHledatPojistku.TextColor = Color.White;
            newButtonHledatPojistku.UseVisualStyleBackColor = false;
            newButtonHledatPojistku.Click += this.newButtonHledatPojistku_Click_1;
            // 
            // VypisPojistky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VypisPojistky";
            Size = new Size(900, 523);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVypisPojistky).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private NewButton newButtonHledatPojistku;
        private TextBox textBox1;
        private DataGridView dataGridViewVypisPojistky;
        private TableLayoutPanel tableLayoutPanel5;
        private RadioButton radioButton2_podlePoznamky;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private NewButton newButtonNULLFILTER;
        private NewButton newButtonHledatPojistku;
    }
}
