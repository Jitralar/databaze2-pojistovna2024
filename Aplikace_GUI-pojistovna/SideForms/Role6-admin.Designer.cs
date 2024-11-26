namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role6_admin
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
            r6label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            r6logout = new NewButton();
            r6profil = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // r6label
            // 
            r6label.AutoSize = true;
            r6label.Location = new Point(3, 336);
            r6label.Name = "r6label";
            r6label.Padding = new Padding(3);
            r6label.Size = new Size(164, 46);
            r6label.TabIndex = 4;
            r6label.Text = "Přihlášen jako uživatel:\r\n*jmeno*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(r6label, 0, 6);
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(r6logout, 1, 0);
            tableLayoutPanel2.Controls.Add(r6profil, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // r6logout
            // 
            r6logout.BackColor = Color.IndianRed;
            r6logout.BackgroundColor = Color.IndianRed;
            r6logout.BorderColor = Color.PaleVioletRed;
            r6logout.BorderRadius = 0;
            r6logout.BorderSize = 0;
            r6logout.FlatAppearance.BorderSize = 0;
            r6logout.FlatStyle = FlatStyle.Flat;
            r6logout.ForeColor = Color.White;
            r6logout.Location = new Point(106, 3);
            r6logout.Name = "r6logout";
            r6logout.Size = new Size(97, 49);
            r6logout.TabIndex = 0;
            r6logout.Text = "logout";
            r6logout.TextColor = Color.White;
            r6logout.UseVisualStyleBackColor = false;
            // 
            // r6profil
            // 
            r6profil.BackColor = Color.LemonChiffon;
            r6profil.BackgroundColor = Color.LemonChiffon;
            r6profil.BorderColor = Color.PaleVioletRed;
            r6profil.BorderRadius = 0;
            r6profil.BorderSize = 0;
            r6profil.FlatAppearance.BorderSize = 0;
            r6profil.FlatStyle = FlatStyle.Flat;
            r6profil.ForeColor = Color.Black;
            r6profil.Location = new Point(3, 3);
            r6profil.Name = "r6profil";
            r6profil.Size = new Size(97, 49);
            r6profil.TabIndex = 1;
            r6profil.Text = "profil";
            r6profil.TextColor = Color.Black;
            r6profil.UseVisualStyleBackColor = false;
            // 
            // Role6_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role6_admin";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label r6label;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton r6logout;
        private NewButton r6profil;
    }
}
