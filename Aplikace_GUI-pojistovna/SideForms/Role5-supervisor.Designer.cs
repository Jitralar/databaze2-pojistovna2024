namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role5_supervisor
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
            r5label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            r5logout = new NewButton();
            r5profil = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // r5label
            // 
            r5label.AutoSize = true;
            r5label.Location = new Point(3, 336);
            r5label.Name = "r5label";
            r5label.Padding = new Padding(3);
            r5label.Size = new Size(164, 46);
            r5label.TabIndex = 4;
            r5label.Text = "Přihlášen jako uživatel:\r\n*jmeno*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(r5label, 0, 6);
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
            tableLayoutPanel2.Controls.Add(r5logout, 1, 0);
            tableLayoutPanel2.Controls.Add(r5profil, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // r5logout
            // 
            r5logout.BackColor = Color.IndianRed;
            r5logout.BackgroundColor = Color.IndianRed;
            r5logout.BorderColor = Color.PaleVioletRed;
            r5logout.BorderRadius = 0;
            r5logout.BorderSize = 0;
            r5logout.FlatAppearance.BorderSize = 0;
            r5logout.FlatStyle = FlatStyle.Flat;
            r5logout.ForeColor = Color.White;
            r5logout.Location = new Point(106, 3);
            r5logout.Name = "r5logout";
            r5logout.Size = new Size(97, 49);
            r5logout.TabIndex = 0;
            r5logout.Text = "logout";
            r5logout.TextColor = Color.White;
            r5logout.UseVisualStyleBackColor = false;
            // 
            // r5profil
            // 
            r5profil.BackColor = Color.LemonChiffon;
            r5profil.BackgroundColor = Color.LemonChiffon;
            r5profil.BorderColor = Color.PaleVioletRed;
            r5profil.BorderRadius = 0;
            r5profil.BorderSize = 0;
            r5profil.FlatAppearance.BorderSize = 0;
            r5profil.FlatStyle = FlatStyle.Flat;
            r5profil.ForeColor = Color.Black;
            r5profil.Location = new Point(3, 3);
            r5profil.Name = "r5profil";
            r5profil.Size = new Size(97, 49);
            r5profil.TabIndex = 1;
            r5profil.Text = "profil";
            r5profil.TextColor = Color.Black;
            r5profil.UseVisualStyleBackColor = false;
            // 
            // Role5_supervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role5_supervisor";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label r5label;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton r5logout;
        private NewButton r5profil;
    }
}
