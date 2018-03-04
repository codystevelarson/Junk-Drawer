using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    class ShowTicketWorkflow
    {
        public void Execute()
        {
            TicketRepository repo = new TicketRepository(Settings.FilePath);
            List<Ticket> tickets = repo.List();

            Console.Clear();
            int ticketID = ConsoleInput.GetNumbersFromUser("Enter a Ticket ID number (000 = All): ");
            var showTicket = tickets.Where(t => t.TicketID == ticketID);

            if (ticketID == 000)
            {
                foreach(var t in tickets)
                {
                    ConsoleOutput.PrintTicket(t);
                }
            }
            else
            {
                foreach (var t in showTicket)
                {
                    ConsoleOutput.PrintTicket(t);
                }
            }
            
            

            
            Console.WriteLine(ConsoleOutput.SeparatorBar);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            
        }
    }
}
