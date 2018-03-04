using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    public class AddTicketWorkflow
    {
        public void Execute()
        {
            Console.Clear();   
            Console.WriteLine("Enter Pick");
            Console.WriteLine(ConsoleOutput.SeparatorBar);
            Console.WriteLine();

            Ticket newTicket = new Ticket();

            newTicket.FirstName = ConsoleInput.GetStringInputFromUser("Enter First Name: ");
            newTicket.LastName = ConsoleInput.GetStringInputFromUser("Enter Last Name: ");

            bool isValidTicket = false;
            while (!isValidTicket)
            {
                newTicket.NumberPicks[0] = ConsoleInput.GetNumbersFromUser("Enter pick number 1: ", 69);
                newTicket.NumberPicks[1] = ConsoleInput.GetNumbersFromUser("Enter pick number 2: ", 69);
                newTicket.NumberPicks[2] = ConsoleInput.GetNumbersFromUser("Enter pick number 3: ", 69);
                newTicket.NumberPicks[3] = ConsoleInput.GetNumbersFromUser("Enter pick number 4: ", 69);
                newTicket.NumberPicks[4] = ConsoleInput.GetNumbersFromUser("Enter pick number 5: ", 69);
                newTicket.Powerball = ConsoleInput.GetNumbersFromUser("Enter powerball number: ", 26);

                //Validate first 5 number picks have no duplicates
                if (newTicket.NumberPicks.Distinct().Count() != 5)
                {
                    ConsoleOutput.RedMessage("First 5 numbers cannot be duplicates.");
                    Console.WriteLine("Press any key to pick new numbers...");
                    Console.ReadKey();
                }
                else
                {
                    isValidTicket = true;
                }
               
            }
            

            Console.WriteLine();

            Console.WriteLine($"{newTicket.FirstName} {newTicket.LastName}");
            Console.Write(ConsoleOutput.PicksToString(newTicket.NumberPicks, true));
            ConsoleOutput.RedMessage(newTicket.Powerball.ToString());
            Console.WriteLine();

            if (ConsoleInput.GetYesNoAnswerFromUser("Add the following information?") == "Y")
            {
                
                TicketRepository repo = new TicketRepository(Settings.FilePath);

                //Set ticket ID number
                //If first ticket - TicketID = 1
                if (repo.List().Count() == 0)
                {
                    newTicket.TicketID = 1;
                }
                //else, set ticket id to the max ticketID in the list + 1
                else
                {
                    newTicket.TicketID = repo.List().Max(t => t.TicketID) + 1;
                }

                //Add ticket
                repo.Add(newTicket);

                Console.WriteLine("Your ticket has been submitted!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ticket input cancelled.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
