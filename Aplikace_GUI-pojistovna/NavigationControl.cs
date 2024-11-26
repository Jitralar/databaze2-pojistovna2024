using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aplikace_GUI_pojistovna
{
    public class NavigationControl
    {
        List<UserControl> mainControlList = new List<UserControl>();
        Panel panel;

        public NavigationControl(Panel panel, List<UserControl> mainControlList)
        {
            this.panel = panel;
            this.mainControlList = mainControlList;
            UserControled();

        }



        private void UserControled()
        {
            for (int i = 0; i < mainControlList.Count; i++)
            {
                mainControlList[i].Dock = DockStyle.Fill; //fill the panel
                panel.Controls.Add(mainControlList[i]); //add the user control to the panel
            }
        }

        public void Display(int index)
        {
            if (index < mainControlList.Count())
            {
                mainControlList[index].BringToFront(); //bring the user control to the front

            }
        }









    }
}
