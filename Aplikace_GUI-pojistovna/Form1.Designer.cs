using Aplikace_GUI_pojistovna.MainForms;

namespace Aplikace_GUI_pojistovna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            f1HOME = new NewButton();
            mainPanel = new Panel();
            sidePanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ControlDarkDark;
            sidePanel.Controls.Add(panel2);
            sidePanel.Controls.Add(panel1);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.Control;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(212, 523);
            sidePanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 453);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 112);
            label1.Name = "label1";
            label1.Size = new Size(198, 180);
            label1.TabIndex = 0;
            label1.Text = "zde bude nahrazny obsah\r\nv základu je zde login\r\na po přihlášení se zde objeví\r\nGUI pro danou roli\r\n\r\nPokud vidíte toto, něco je\r\nšpatně...\r\n\r\nDEV ONLY";
            // 
            // panel1
            // 
            panel1.Controls.Add(f1HOME);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 70);
            panel1.TabIndex = 0;
            // 
            // f1HOME
            // 
            f1HOME.BackColor = Color.DarkOrange;
            f1HOME.BackgroundColor = Color.DarkOrange;
            f1HOME.BorderColor = Color.PaleVioletRed;
            f1HOME.BorderRadius = 0;
            f1HOME.BorderSize = 0;
            f1HOME.Dock = DockStyle.Fill;
            f1HOME.FlatAppearance.BorderSize = 0;
            f1HOME.FlatStyle = FlatStyle.Flat;
            f1HOME.ForeColor = Color.White;
            f1HOME.Location = new Point(0, 0);
            f1HOME.Name = "f1HOME";
            f1HOME.Size = new Size(212, 70);
            f1HOME.TabIndex = 0;
            f1HOME.Text = "logo / home";
            f1HOME.TextColor = Color.White;
            f1HOME.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(212, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 523);
            mainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 523);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Name = "Form1";
            Text = "Form1";
            sidePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel mainPanel;
        private NewButton f1HOME;
    }



}
