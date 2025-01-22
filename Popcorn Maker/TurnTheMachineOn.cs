using System;

namespace Popcorn_Maker
{
    public sealed class TurnTheMachineOn
    {
        private string response;

        public void TurnONMachine()
        {
            do
            {

                Console.WriteLine("");
                Console.Write("--- For Starting the Machine Enter S : ");
                response = Console.ReadLine().ToUpper();
                Console.Clear();
            }
            while (response != "S");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("   The POPCORN maker is ON , you can start the making popcorn !!  ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any ... ");
            Console.ReadKey();
        }


    }
}



