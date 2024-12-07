namespace Aplikace_GUI_pojistovna.MainForms
{
    partial class UserRegister
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
            panel1 = new Panel();
            urText = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox21 = new TextBox();
            textBox17 = new TextBox();
            textBox15 = new TextBox();
            textBox13 = new TextBox();
            textBox7 = new TextBox();
            textBoxProstredniJmeno = new TextBox();
            textBoxJmeno = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox5 = new TextBox();
            textBox8 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(urText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 70);
            panel1.TabIndex = 0;
            // 
            // urText
            // 
            urText.AutoSize = true;
            urText.Dock = DockStyle.Bottom;
            urText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            urText.ForeColor = Color.DarkOrange;
            urText.Location = new Point(0, 24);
            urText.Name = "urText";
            urText.Size = new Size(506, 46);
            urText.TabIndex = 0;
            urText.Text = "Moderní pojišťovna 21. století";
            urText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(textBox21, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox17, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox15, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox13, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox7, 2, 1);
            tableLayoutPanel1.Controls.Add(textBoxProstredniJmeno, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxJmeno, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox4, 0, 6);
            tableLayoutPanel1.Controls.Add(label1, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(checkBox3, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 3, 1);
            tableLayoutPanel1.Controls.Add(label3, 3, 2);
            tableLayoutPanel1.Controls.Add(label4, 3, 4);
            tableLayoutPanel1.Controls.Add(label5, 3, 5);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(900, 453);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox21
            // 
            textBox21.Dock = DockStyle.Fill;
            textBox21.Location = new Point(3, 283);
            textBox21.Name = "textBox21";
            textBox21.PlaceholderText = "Email (uživatelské jméno)";
            textBox21.Size = new Size(219, 27);
            textBox21.TabIndex = 22;
            // 
            // textBox17
            // 
            textBox17.Dock = DockStyle.Fill;
            textBox17.Location = new Point(3, 227);
            textBox17.Name = "textBox17";
            textBox17.PlaceholderText = "Město";
            textBox17.Size = new Size(219, 27);
            textBox17.TabIndex = 18;
            // 
            // textBox15
            // 
            textBox15.Dock = DockStyle.Fill;
            textBox15.Location = new Point(453, 171);
            textBox15.Name = "textBox15";
            textBox15.PlaceholderText = "PSČ";
            textBox15.Size = new Size(219, 27);
            textBox15.TabIndex = 16;
            // 
            // textBox13
            // 
            textBox13.Dock = DockStyle.Fill;
            textBox13.Location = new Point(3, 171);
            textBox13.Name = "textBox13";
            textBox13.PlaceholderText = "Ulice";
            textBox13.Size = new Size(219, 27);
            textBox13.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(453, 59);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Příjmení";
            textBox7.Size = new Size(219, 27);
            textBox7.TabIndex = 8;
            // 
            // textBoxProstredniJmeno
            // 
            textBoxProstredniJmeno.Dock = DockStyle.Fill;
            textBoxProstredniJmeno.Location = new Point(228, 59);
            textBoxProstredniJmeno.Name = "textBoxProstredniJmeno";
            textBoxProstredniJmeno.PlaceholderText = "Prostřední jméno";
            textBoxProstredniJmeno.Size = new Size(219, 27);
            textBoxProstredniJmeno.TabIndex = 7;
            // 
            // textBoxJmeno
            // 
            textBoxJmeno.Dock = DockStyle.Fill;
            textBoxJmeno.Location = new Point(3, 59);
            textBoxJmeno.Name = "textBoxJmeno";
            textBoxJmeno.PlaceholderText = "Jméno";
            textBoxJmeno.Size = new Size(219, 27);
            textBoxJmeno.TabIndex = 2;
            textBoxJmeno.TextChanged += textBoxJmeno_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel2.Location = new Point(228, 171);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(219, 50);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 0);
            textBox2.Margin = new Padding(3, 0, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "číslo popisné";
            textBox2.Size = new Size(103, 27);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 0);
            textBox3.Margin = new Padding(3, 0, 3, 3);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "číslo orientační";
            textBox3.Size = new Size(104, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(3, 339);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.PlaceholderText = "Heslo";
            textBox4.Size = new Size(219, 27);
            textBox4.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Location = new Point(228, 339);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 40);
            label1.TabIndex = 39;
            label1.Text = "Heslo musí mít minimálně 8 znaků, obsahovat velké i malé písmeno, číslici a speciální znak (např. !, @, #, $, %).";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Controls.Add(textBox5, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox8, 1, 0);
            tableLayoutPanel3.Location = new Point(228, 283);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(219, 50);
            tableLayoutPanel3.TabIndex = 40;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Top;
            textBox5.Location = new Point(3, 0);
            textBox5.Margin = new Padding(3, 0, 3, 3);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "prefix";
            textBox5.Size = new Size(70, 27);
            textBox5.TabIndex = 0;
            textBox5.Text = "+420";
            // 
            // textBox8
            // 
            textBox8.Dock = DockStyle.Fill;
            textBox8.Location = new Point(79, 0);
            textBox8.Margin = new Padding(3, 0, 3, 3);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "telefoní číslo";
            textBox8.Size = new Size(137, 27);
            textBox8.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 28);
            comboBox1.TabIndex = 41;
            comboBox1.Text = "Vyberte Kraj";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(3, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(219, 50);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Četl(a) jsem podmínky používání aplikace";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Dock = DockStyle.Fill;
            checkBox2.Location = new Point(228, 115);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(219, 50);
            checkBox2.TabIndex = 43;
            checkBox2.Text = "Souhlasím se zpracováním osobních údajů";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Dock = DockStyle.Fill;
            checkBox3.Location = new Point(453, 115);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(219, 50);
            checkBox3.TabIndex = 44;
            checkBox3.Text = "Prohlašuji, že všechny mnou zadané údaje jsou pravdivé";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(678, 95);
            label2.Name = "label2";
            label2.Size = new Size(219, 17);
            label2.TabIndex = 45;
            label2.Text = "Jméno a příjmení";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(678, 151);
            label3.Name = "label3";
            label3.Size = new Size(219, 17);
            label3.TabIndex = 46;
            label3.Text = "Podmínky využívání";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(678, 263);
            label4.Name = "label4";
            label4.Size = new Size(219, 17);
            label4.TabIndex = 47;
            label4.Text = "Adresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(678, 319);
            label5.Name = "label5";
            label5.Size = new Size(219, 17);
            label5.TabIndex = 48;
            label5.Text = "Kontaktní informace";
            // 
            // label6
            // 
            label6.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label6, 4);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(883, 40);
            label6.TabIndex = 49;
            label6.Text = "Registrací získáváte přístup k nejlepší pojišťovně a modernímu systému Oasis, který vám umožní snadno spravovat vaše pojistky, mít přehled o smlouvách a využívat výhodné služby na jednom místě.";
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UserRegister";
            Size = new Size(900, 523);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label urText;
        private TableLayoutPanel tableLayoutPanel1;
        private NewButton urRegistrovat;
        private TextBox textBoxJmeno;
        private TextBox textBox21;
        private TextBox textBox17;
        private TextBox textBox15;
        private TextBox textBox13;
        private TextBox textBox7;
        private TextBox textBoxProstredniJmeno;
        private NewButton newButton13;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox5;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
