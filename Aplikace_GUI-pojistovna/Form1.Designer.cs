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
            panel1 = new Panel();
            sidePanel.SuspendLayout();
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 453);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 70);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 523);
            Controls.Add(sidePanel);
            Name = "Form1";
            Text = "Form1";
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel panel1;
        private Panel panel2;
    }
}
