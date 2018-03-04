using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    class ConsoleOutput
    {
        public const string SeparatorBar = "+===========================================================+";

              
        //Display number picks to string
        public static string PicksToString(int[] picks, bool space)
        {
            string output = "";
            foreach (int pick in picks)
            {
                if(!space)
                output += $"{pick.ToString()}.";
                else
                output += $"{pick.ToString()} ";
            }
            return output;
        }

        public static void PrintTicket(Ticket t)
        {
            
            Console.WriteLine($"Ticket ID: {t.TicketID}");
            Console.WriteLine($"Name:{t.FirstName} {t.LastName}");
            Console.Write($"Number Picks: {PicksToString(t.NumberPicks, true)}");
            RedMessage($"{t.Powerball}");
            Console.WriteLine();

        }

        public static void PrintWinningTicket(WinningTicket t, int winningNums)
        {
            if (winningNums == 6)
            {
                RedMessage("WINNER WINNER CHICKEN DINNER!");
            }
            Console.WriteLine($"Ticket ID: {t.Ticket.TicketID}");
            Console.WriteLine($"Name:{t.Ticket.FirstName} {t.Ticket.LastName}");
            Console.Write($"Number Picks: {PicksToString(t.Ticket.NumberPicks, true)}");
            RedMessage($"{t.Ticket.Powerball}");
            Console.WriteLine($"Winning number matches: {winningNums}");
            Console.WriteLine();

        }

        public static void RedMessage(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(prompt);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void BlueMessage(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(prompt);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
