using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 62;
            TicketRepository tickets = new TicketRepository(Settings.FilePath);
            tickets.Init();
            MainMenu.Show();
        }
    }
}
