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
    public partial class Role5_supervisor : UserControl
    {
        public Role5_supervisor()
        {
            InitializeComponent();
        }

        private void r5profil_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení UserProfil
                mainForm.ShowUserProfile();
            }
        }

        private void r5zamestnanci_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení VypisZamestnance
                mainForm.ShowVypisZamestnance();
            }
        }

        private void r5statsklienti_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyKlientu
                mainForm.ShowStatistikyKlientu();
            }
        }

        private void r5statszamestnanci_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyZamestnancu
                mainForm.ShowStatistikyZamestnancu();
            }
        }

        private void r5statspojistek_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyPojistek
                mainForm.ShowStatistikyPojistek();
            }
        }

        private void r5statspobocek_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení StatistikyPobocek
                mainForm.ShowStatistikyPobocek();
            }
        }

        private void r5delegate_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Zavolej metodu pro zobrazení PridelitKlientaZamestnanci
                mainForm.ShowPridelitKlientaZamestnanci();
            }
        }

        private void r5logout_Click(object sender, EventArgs e)
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
