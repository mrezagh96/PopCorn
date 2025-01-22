using System;
using System.Xml.Linq;

namespace Popcorn_Maker
{
    internal class Menu 
    {
        private string response;
        public string Response { get { return response; } set { response = value; } }

        public void MenuShow()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Here is the menu : ");
            Console.WriteLine("");
            Console.WriteLine("Press -P- for making POPCORN !  ");
            Console.WriteLine("Press -O- for turning the machine off ");
            Console.WriteLine("-----------------------------------------");
            response = Console.ReadLine().ToUpper();

        }
    }
}
