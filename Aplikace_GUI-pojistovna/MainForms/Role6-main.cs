using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikace_GUI_pojistovna.MainForms
{
    public partial class Role6_main : UserControl
    {
        public Role6_main()
        {
            InitializeComponent();
        }

        private void newButtonEMULACE_r2_Click(object sender, EventArgs e)
        {
            var sideForm = this.FindForm() as Form1;
            if (sideForm != null)
            {
                // Zavolej metodu pro zobrazení Role2
                sideForm.EmulaceRole(2);
            }

        }

        private void newButtonEMULACE_r3_Click(object sender, EventArgs e)
        {
            var sideForm = this.FindForm() as Form1;
            if (sideForm != null)
            {
                // Zavolej metodu pro zobrazení Role3
                sideForm.EmulaceRole(3);
            }
        }

        private void newButtonEMULACE_r4_Click(object sender, EventArgs e)
        {
            var sideForm = this.FindForm() as Form1;
            if (sideForm != null)
            {
                // Zavolej metodu pro zobrazení Role4
                sideForm.EmulaceRole(4);
            }
        }

        private void newButtonEMULACE_r5_Click(object sender, EventArgs e)
        {
            var sideForm = this.FindForm() as Form1;
            if (sideForm != null)
            {
                // Zavolej metodu pro zobrazení Role5
                sideForm.EmulaceRole(5);
            }
        }
    }
}
