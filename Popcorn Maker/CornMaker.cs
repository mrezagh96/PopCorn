using System;

namespace Popcorn_Maker
{
    internal class CornMaker
    {
        private string response;
        public string Response { get { return response; } set { response = value; } }
        public void CheckCornStorage()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("   Is there any raw corn in the storage or not?  ");
            Console.WriteLine("");
            Console.WriteLine(" Yes / No ");
            Console.Write(" Your Response : ");

            bool check = false;
            do { 
            response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "no"  :
                    Console.WriteLine("");
                    Console.WriteLine("     So Put Some In The Machine then Press P button again. ");
                        check = true;
                    Console.ReadKey();
                    break;
                case "n":
                    goto case "no";

                case "yes":
                        Console.WriteLine("");
                        Console.WriteLine("     Your POPCORN is ready ! ");
                        check = true;
                        Console.ReadKey();
                        break;
                case "y":
                    goto case "yes";

                default:
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("   Is there any raw corn in the storage or not?  ");
                        Console.WriteLine("");
                        Console.WriteLine(" Yes / No ");
                        Console.Write(" Your Response : ");
                        check = false;
                    break;
            }
            } while (check == false);

        }
    }
}
