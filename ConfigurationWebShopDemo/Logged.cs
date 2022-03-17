using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo
{
    static public class Logged
    {
        private static bool loggedIn = false;
        private static bool isAdmin = false;
        public static bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public static bool LoggedIn { get => loggedIn; set => loggedIn = value; }
    }
}
