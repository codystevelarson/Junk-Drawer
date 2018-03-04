using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Powerball
{
    public class MainMenu
    {
        //MainMenu
        public static bool MainMenuChoice()
        {
            string mmChoice = ConsoleInput.GetStringInputFromUser("Please choose an option (1-3): ").ToUpper();
            switch (mmChoice)
            {
                case "1":
                    AddTicketWorkflow addFlow = new AddTicketWorkflow();
                    addFlow.Execute();
                    break;
                case "2":
                    ShowTicketWorkflow showFlow = new ShowTicketWorkflow();
                    showFlow.Execute();
                    break;
                case "3":
                    DrawTicketWorkflow drawFlow = new DrawTicketWorkflow();
                    drawFlow.Execute();
                    break;
                case "Q":
                    return false;
                default:
                    Console.WriteLine("That is not a valid choice!\nPress any key to continue...");
                    Console.ReadKey();
                    break;
            }
            return true;
        }


        public static void DisplayMenu()
        {
            Console.Clear();
            ConsoleOutput.RedMessage("                      POWERBALL!                 ");
            Console.WriteLine("Main Menu");
            Console.WriteLine(ConsoleOutput.SeparatorBar);
            Console.WriteLine("1. Enter Pick");
            Console.WriteLine("2. Show a Pick");
            Console.WriteLine("3. Draw");
            Console.WriteLine();
            Console.WriteLine("Q - Quit");
            Console.WriteLine(ConsoleOutput.SeparatorBar);
            Console.WriteLine();
        }

        public static void SplashScreen()
        {
            
            for(int i = 0; i < 5; i++)
            {
                Console.Clear();
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                Thread.Sleep(75);
                Console.Clear();
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                ConsoleOutput.RedMessage("!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!");
                ConsoleOutput.BlueMessage("¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡POWERBALL!POWERBALL¡");
                Thread.Sleep(75);
            }
            
        }

        public static void Show()
        {
            
            bool continueRunning = true;

            while (continueRunning)
            {
                SplashScreen();
                DisplayMenu();
                continueRunning = MainMenuChoice();
            }
        }
    }
}
