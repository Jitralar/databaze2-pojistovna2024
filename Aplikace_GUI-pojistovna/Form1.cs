using Aplikace_GUI_pojistovna.MainForms;
using Aplikace_GUI_pojistovna.SideForms;
using Aplikace_GUI_pojistovna.SpecificForms;

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
            { 
                new UserRegister(), new Role2_main(), new Role3_main(), new role4_main(), new Role5_main(), new Role6_main(), new UserProfil(), 
                new PridelitKlientaZamestnanci(), new StatistikyKlientu(), new StatistikyPobocek(), new StatistikyPojistek(), new StatistikyZamestnancu(), new UpravitObsahTabulky(), new UzivatelVypisPojistek(), new VypisKlienty(), new VypisPojistky(), new VypisZamestnance(), new VytvoritPojistku(), new ZobrazitLog()
            }; //FIXME: add další jak budu pøidávat


            navigationControl = new NavigationControl(mainPanel, mainControlList);

            //-----------------Display the first user control-----------------

            //1 - role2main.cs
            //2 - role3main.cs
            //3 - userRegister.cs
            //4 - role4main.cs
            //5 - role5main.cs
            //6 - role6main.cs
            //7 - userProfil.cs
            //8 - pridelitKlientaZamestnanci.cs
            //9 - statistikyKlientu.cs
            //10 - statistikyPobocek.cs
            //11 - statistikyPojistek.cs
            //12 - statistikyZamestnancu.cs
            //13 - upravitObsahTabulky.cs
            //14 - uzivatelVypisPojistek.cs
            //15 - vypisKlienty.cs
            //16 - vypisPojistky.cs
            //17 - vypisZamestnance.cs
            //18 - vytvoritPojistku.cs
            //19 - zobrazitLog.cs


            navigationControl.Display(3); // = disply na main panelu ve Form1.cs


            // more to be addded, even if you never use them
            // idk it could be someday usefull...
            //----------------------------------------------------------------

            List<UserControl> sideControlList = new List<UserControl>()
            { new Login(), new Role1_registrovanyUser(), new role3_zamestnanec(), new Role4_analytik(), new Role5_supervisor(), new Role6_admin()};
            navigationControl = new NavigationControl(sidePanel, sideControlList);
            navigationControl.Display(0);

            //WARNING: role1_registrovanyUser.cs je vedena jako role1, ale vzhledem k tomu, ze se to nepropsalo a nechci riskovat nefunkènost a hrabani se v tom, tak jsem to nechal takto

        }

    }

}
