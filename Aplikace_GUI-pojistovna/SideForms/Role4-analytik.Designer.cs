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
            r4statistikypobocek = new NewButton();
            r4statspojistky = new NewButton();
            r4statszamestnanci = new NewButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            r4logout = new NewButton();
            r4profil = new NewButton();
            r4statsklienti = new NewButton();
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
            tableLayoutPanel1.Controls.Add(r4statistikypobocek, 0, 3);
            tableLayoutPanel1.Controls.Add(r4statspojistky, 0, 2);
            tableLayoutPanel1.Controls.Add(r4statszamestnanci, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(r4label, 0, 6);
            tableLayoutPanel1.Controls.Add(r4statsklienti, 0, 0);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(212, 453);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // r4statistikypobocek
            // 
            r4statistikypobocek.BackColor = Color.MediumSlateBlue;
            r4statistikypobocek.BackgroundColor = Color.MediumSlateBlue;
            r4statistikypobocek.BorderColor = Color.PaleVioletRed;
            r4statistikypobocek.BorderRadius = 0;
            r4statistikypobocek.BorderSize = 0;
            r4statistikypobocek.Dock = DockStyle.Fill;
            r4statistikypobocek.FlatAppearance.BorderSize = 0;
            r4statistikypobocek.FlatStyle = FlatStyle.Flat;
            r4statistikypobocek.ForeColor = Color.White;
            r4statistikypobocek.Location = new Point(3, 171);
            r4statistikypobocek.Name = "r4statistikypobocek";
            r4statistikypobocek.Size = new Size(206, 50);
            r4statistikypobocek.TabIndex = 8;
            r4statistikypobocek.Text = "Statistiky Poboček";
            r4statistikypobocek.TextColor = Color.White;
            r4statistikypobocek.UseVisualStyleBackColor = false;
            r4statistikypobocek.Click += r4statistikypobocek_Click;
            // 
            // r4statspojistky
            // 
            r4statspojistky.BackColor = Color.MediumSlateBlue;
            r4statspojistky.BackgroundColor = Color.MediumSlateBlue;
            r4statspojistky.BorderColor = Color.PaleVioletRed;
            r4statspojistky.BorderRadius = 0;
            r4statspojistky.BorderSize = 0;
            r4statspojistky.Dock = DockStyle.Fill;
            r4statspojistky.FlatAppearance.BorderSize = 0;
            r4statspojistky.FlatStyle = FlatStyle.Flat;
            r4statspojistky.ForeColor = Color.White;
            r4statspojistky.Location = new Point(3, 115);
            r4statspojistky.Name = "r4statspojistky";
            r4statspojistky.Size = new Size(206, 50);
            r4statspojistky.TabIndex = 7;
            r4statspojistky.Text = "Statistiky Pojistek";
            r4statspojistky.TextColor = Color.White;
            r4statspojistky.UseVisualStyleBackColor = false;
            r4statspojistky.Click += r4statspojistky_Click;
            // 
            // r4statszamestnanci
            // 
            r4statszamestnanci.BackColor = Color.MediumSlateBlue;
            r4statszamestnanci.BackgroundColor = Color.MediumSlateBlue;
            r4statszamestnanci.BorderColor = Color.PaleVioletRed;
            r4statszamestnanci.BorderRadius = 0;
            r4statszamestnanci.BorderSize = 0;
            r4statszamestnanci.Dock = DockStyle.Fill;
            r4statszamestnanci.FlatAppearance.BorderSize = 0;
            r4statszamestnanci.FlatStyle = FlatStyle.Flat;
            r4statszamestnanci.ForeColor = Color.White;
            r4statszamestnanci.Location = new Point(3, 59);
            r4statszamestnanci.Name = "r4statszamestnanci";
            r4statszamestnanci.Size = new Size(206, 50);
            r4statszamestnanci.TabIndex = 6;
            r4statszamestnanci.Text = "Statistiky Zaměstnanců";
            r4statszamestnanci.TextColor = Color.White;
            r4statszamestnanci.UseVisualStyleBackColor = false;
            r4statszamestnanci.Click += r4statszamestnanci_Click;
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
            r4logout.Click += r4logout_Click;
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
            r4profil.Click += r4profil_Click;
            // 
            // r4statsklienti
            // 
            r4statsklienti.BackColor = Color.MediumSlateBlue;
            r4statsklienti.BackgroundColor = Color.MediumSlateBlue;
            r4statsklienti.BorderColor = Color.PaleVioletRed;
            r4statsklienti.BorderRadius = 0;
            r4statsklienti.BorderSize = 0;
            r4statsklienti.Dock = DockStyle.Fill;
            r4statsklienti.FlatAppearance.BorderSize = 0;
            r4statsklienti.FlatStyle = FlatStyle.Flat;
            r4statsklienti.ForeColor = Color.White;
            r4statsklienti.Location = new Point(3, 3);
            r4statsklienti.Name = "r4statsklienti";
            r4statsklienti.Size = new Size(206, 50);
            r4statsklienti.TabIndex = 5;
            r4statsklienti.Text = "Statistiky Klientů";
            r4statsklienti.TextColor = Color.White;
            r4statsklienti.UseVisualStyleBackColor = false;
            r4statsklienti.Click += r4statsklienti_Click;
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
        private NewButton r4statistikypobocek;
        private NewButton r4statspojistky;
        private NewButton r4statszamestnanci;
        private NewButton r4statsklienti;
    }
}
