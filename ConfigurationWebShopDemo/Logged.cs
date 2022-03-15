using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo
{
    static public class Logged
    {
        private static bool loggedIn = false;
        public static bool LoggedIn { get => loggedIn; set => loggedIn = value; }
    }
}
