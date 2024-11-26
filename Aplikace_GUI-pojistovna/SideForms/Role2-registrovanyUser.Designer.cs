namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role1_registrovanyUser
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
            r2mojePojistky = new NewButton();
            newButton2 = new NewButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(newButton2, 0, 1);
            tableLayoutPanel1.Controls.Add(r2mojePojistky, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.Size = new Size(212, 453);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // r2mojePojistky
            // 
            r2mojePojistky.BackColor = Color.MediumSlateBlue;
            r2mojePojistky.BackgroundColor = Color.MediumSlateBlue;
            r2mojePojistky.BorderColor = Color.PaleVioletRed;
            r2mojePojistky.BorderRadius = 0;
            r2mojePojistky.BorderSize = 0;
            r2mojePojistky.Dock = DockStyle.Fill;
            r2mojePojistky.FlatAppearance.BorderSize = 0;
            r2mojePojistky.FlatStyle = FlatStyle.Flat;
            r2mojePojistky.ForeColor = Color.White;
            r2mojePojistky.Location = new Point(3, 3);
            r2mojePojistky.Name = "r2mojePojistky";
            r2mojePojistky.Size = new Size(206, 50);
            r2mojePojistky.TabIndex = 0;
            r2mojePojistky.Text = "Moje pojistky";
            r2mojePojistky.TextColor = Color.White;
            r2mojePojistky.UseVisualStyleBackColor = false;
            // 
            // newButton2
            // 
            newButton2.BackColor = Color.LightYellow;
            newButton2.BackgroundColor = Color.LightYellow;
            newButton2.BorderColor = Color.PaleVioletRed;
            newButton2.BorderRadius = 0;
            newButton2.BorderSize = 0;
            newButton2.Dock = DockStyle.Fill;
            newButton2.FlatAppearance.BorderSize = 0;
            newButton2.FlatStyle = FlatStyle.Flat;
            newButton2.ForeColor = Color.Black;
            newButton2.Location = new Point(3, 59);
            newButton2.Name = "newButton2";
            newButton2.Size = new Size(206, 50);
            newButton2.TabIndex = 2;
            newButton2.Text = "newButton2";
            newButton2.TextColor = Color.Black;
            newButton2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // Role1_registrovanyUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role1_registrovanyUser";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private NewButton r2mojePojistky;
        private NewButton newButton2;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
