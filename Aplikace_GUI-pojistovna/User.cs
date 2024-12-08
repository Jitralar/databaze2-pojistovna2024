using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikace_GUI_pojistovna
{
    public class User
    {
        public static class CurrentUser
        {
            public static string FullName { get; set; }
            public static string Email { get; set; }
            public static int Role { get; set; }
        }

    }
}
