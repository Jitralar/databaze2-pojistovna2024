namespace Aplikace_GUI_pojistovna.SideForms
{
    partial class Login
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
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabel2 = new LinkLabel();
            textBox3 = new TextBox();
            newButton2 = new NewButton();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 6);
            tableLayoutPanel1.Controls.Add(newButton2, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 4);
            tableLayoutPanel1.Controls.Add(linkLabel2, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(212, 453);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 56);
            label3.TabIndex = 9;
            label3.Text = "Vítejte zpět!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(11, 70);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Uživatelské jméno";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(11, 126);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Heslo";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 11;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Dock = DockStyle.Fill;
            linkLabel2.Location = new Point(3, 168);
            linkLabel2.MaximumSize = new Size(210, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Padding = new Padding(3);
            linkLabel2.Size = new Size(206, 56);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Zažádat o obnovení přístupu";
            linkLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(11, 238);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "2fa*";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 13;
            // 
            // newButton2
            // 
            newButton2.BackColor = Color.MediumSlateBlue;
            newButton2.BackgroundColor = Color.MediumSlateBlue;
            newButton2.BorderColor = Color.PaleVioletRed;
            newButton2.BorderRadius = 0;
            newButton2.BorderSize = 0;
            newButton2.Dock = DockStyle.Fill;
            newButton2.FlatAppearance.BorderSize = 0;
            newButton2.FlatStyle = FlatStyle.Flat;
            newButton2.ForeColor = Color.White;
            newButton2.Location = new Point(3, 283);
            newButton2.Name = "newButton2";
            newButton2.Size = new Size(206, 50);
            newButton2.TabIndex = 14;
            newButton2.Text = "Log In";
            newButton2.TextColor = Color.White;
            newButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 336);
            label1.MaximumSize = new Size(220, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 51);
            label1.TabIndex = 15;
            label1.Text = "*pokud je nastavena 2fa (dvoufaktorová autorizace), je potřeba zadat 6 místní kód";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Size = new Size(212, 453);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private NewButton newButton2;
        private TextBox textBox3;
        private LinkLabel linkLabel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}
