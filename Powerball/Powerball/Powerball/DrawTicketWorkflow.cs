using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    public class DrawTicketWorkflow
    {
        public void Execute()
        {
            Ticket winner = new Ticket();

            winner.TicketID = 999999999;
            winner.FirstName = "Winning";
            winner.LastName = "Ticket";

            bool validPicks = false;
            while(!validPicks)
            {
                winner.NumberPicks[0] = RNG.GetRandom(1, 70);
                winner.NumberPicks[1] = RNG.GetRandom(1, 70);
                winner.NumberPicks[2] = RNG.GetRandom(1, 70);
                winner.NumberPicks[3] = RNG.GetRandom(1, 70);
                winner.NumberPicks[4] = RNG.GetRandom(1, 70);
                if (winner.NumberPicks.Distinct().Count() == 5)
                {
                    validPicks = true;
                }
            }

            winner.Powerball = RNG.GetRandom(1, 27);

            TicketRepository repo = new TicketRepository(Settings.FilePath);

            //Get ticket list
            List<Ticket> tickets = repo.List();

            //Create a new list for winning tickets
            List<WinningTicket> winningTickets = new List<WinningTicket>();

            //Compare tickets to winning ticket & add winners to winningTicket list
            foreach (var ticket in tickets)
            {
                //return a count of numberPicks that match the winning ticket numberPicks
                int winningNums = winner.NumberPicks.Intersect(ticket.NumberPicks).Count();

                //Check if winning-ticket and ticket powerballs match
                if (winner.Powerball == ticket.Powerball)
                {
                    winningNums++;
                }
                
                if(winningNums > 0)
                {
                    WinningTicket winningTicket = new WinningTicket(ticket, winningNums);
                    winningTickets.Add(winningTicket);
                }
            }

            //Sort winners by matching number count
            //print out winners from winer list
            foreach (var w in winningTickets.OrderBy(tix => tix.MatchCount))
            {
                ConsoleOutput.PrintWinningTicket(w, w.MatchCount);
            }
            Console.WriteLine(ConsoleOutput.SeparatorBar);
            ConsoleOutput.PrintTicket(winner);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
