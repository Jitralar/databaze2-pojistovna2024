using Aplikace_GUI_pojistovna.MainForms;

namespace Aplikace_GUI_pojistovna
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }



        private void InitializeNavigationControl()
        {

            List<UserControl> mainControlList = new List<UserControl>()
            { new UserRegister(), new Role2_main(), new Role3_main()}; //FIXME: add další jak budu pøidávat


            navigationControl = new NavigationControl(mainPanel, mainControlList);

            //-----------------Display the first user control-----------------

            //1 - role2main.cs
            //2 - role3main.cs
            //3 - userRegister.cs

            navigationControl.Display(3); // = disply na main panelu ve Form1.cs


            // more to be addded, even if you never use them
            // idk it could be someday usefull...
            //----------------------------------------------------------------

        }

    }

}
