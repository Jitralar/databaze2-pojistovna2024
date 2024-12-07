using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikace_GUI_pojistovna.SideForms
{
    public partial class Role6_admin : UserControl
    {
        public Role6_admin()
        {
            InitializeComponent();
        }

        private void r6profil_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení UserProfil
                mainForm.ShowUserProfile();
            }
        }

        private void r6modeifyTabulky_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení ModifyTabulky
                mainForm.ShowUpravitObsahTabulek();
            }
        }

        private void r6log_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení Log
                mainForm.ShowLog();
            }
        }

        private void r6statsklient_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyKlientu
                mainForm.ShowStatistikyKlientu();
            }
        }

        private void r6statszamestnancu_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyZamestnancu
                mainForm.ShowStatistikyZamestnancu();
            }
        }

        private void r6statspojistek_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyPojistek
                mainForm.ShowStatistikyPojistek();
            }
        }

        private void r6statspobocek_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyPobocek
                mainForm.ShowStatistikyPobocek();
            }
        }

        private void r6logout_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Přepnutí na přihlašovací obrazovku
                mainForm.ShowMainScreenRoleBased(0); // Hlavní panel na přihlašovací obrazovku
                mainForm.ShowSideScreenRoleBased(0); // Vedlejší panel na přihlašovací obrazovku

                var loginControl = mainForm.Controls.OfType<Login>().FirstOrDefault();
                if (loginControl != null)
                {
                    loginControl.ClearLoginFields();
                }
            }
        }
    }
}

