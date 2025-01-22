using System;

namespace Popcorn_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopChecking = true;

            TurnTheMachineOn turnOn = new TurnTheMachineOn();
            turnOn.TurnONMachine();

            do
            {
                Menu menu = new Menu();
                menu.MenuShow();

                switch (menu.Response)
                {
                    case "P":
                        CornMaker cornMaker = new CornMaker();  
                        cornMaker.CheckCornStorage();
                        break;

                    case "O":
                        TurnTheMachineOFF turnOff = new TurnTheMachineOFF();
                        turnOff.TurnOFFMachine();
                        loopChecking = false;
                        break;

                    default:
                        Console.Clear();
                        break;
                }

            } while (loopChecking == true);
        }
    }
}

