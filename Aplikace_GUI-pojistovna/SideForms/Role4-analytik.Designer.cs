namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Role4_analytik
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
            r4label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            r4logout = new NewButton();
            r4profil = new NewButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // r4label
            // 
            r4label.AutoSize = true;
            r4label.Location = new Point(3, 336);
            r4label.Name = "r4label";
            r4label.Padding = new Padding(3);
            r4label.Size = new Size(164, 46);
            r4label.TabIndex = 4;
            r4label.Text = "Přihlášen jako uživatel:\r\n*jmeno*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(r4label, 0, 6);
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
            tableLayoutPanel2.Controls.Add(r4logout, 1, 0);
            tableLayoutPanel2.Controls.Add(r4profil, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(206, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // r4logout
            // 
            r4logout.BackColor = Color.IndianRed;
            r4logout.BackgroundColor = Color.IndianRed;
            r4logout.BorderColor = Color.PaleVioletRed;
            r4logout.BorderRadius = 0;
            r4logout.BorderSize = 0;
            r4logout.FlatAppearance.BorderSize = 0;
            r4logout.FlatStyle = FlatStyle.Flat;
            r4logout.ForeColor = Color.White;
            r4logout.Location = new Point(106, 3);
            r4logout.Name = "r4logout";
            r4logout.Size = new Size(97, 49);
            r4logout.TabIndex = 0;
            r4logout.Text = "logout";
            r4logout.TextColor = Color.White;
            r4logout.UseVisualStyleBackColor = false;
            // 
            // r4profil
            // 
            r4profil.BackColor = Color.LemonChiffon;
            r4profil.BackgroundColor = Color.LemonChiffon;
            r4profil.BorderColor = Color.PaleVioletRed;
            r4profil.BorderRadius = 0;
            r4profil.BorderSize = 0;
            r4profil.FlatAppearance.BorderSize = 0;
            r4profil.FlatStyle = FlatStyle.Flat;
            r4profil.ForeColor = Color.Black;
            r4profil.Location = new Point(3, 3);
            r4profil.Name = "r4profil";
            r4profil.Size = new Size(97, 49);
            r4profil.TabIndex = 1;
            r4profil.Text = "profil";
            r4profil.TextColor = Color.Black;
            r4profil.UseVisualStyleBackColor = false;
            // 
            // Role4_analytik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Role4_analytik";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label r4label;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private NewButton r4logout;
        private NewButton r4profil;
    }
}
