using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBallWebApp.Models
{
    public class TicketRepository
    {
        private static Random rand = new Random();
        private static List<Ticket> _tickets;

        static TicketRepository()
        {
            _tickets = new List<Ticket>()
            {
                new Ticket { FirstName = "Emily", LastName = "Tobolt", Numbers = new int[] { 23, 46, 55, 32, 10 }, PowerBall = 5, ID = 1 },
                new Ticket { FirstName = "Zac", LastName = "Petrich", Numbers = new int[] { 6, 8, 20, 4, 55 }, PowerBall = 22, ID = 2 },
                new Ticket { FirstName = "Bill", LastName = "Cheney", Numbers = new int[] { 23, 46, 9, 12, 45 }, PowerBall = 12, ID = 3 }
            };
        }

        public static Ticket Add(Ticket ticket)
        {
            if (_tickets.Any())
            {
                ticket.ID = _tickets.Max(e => e.ID) + 1;
                _tickets.Add(ticket);

            }
            else
            {
                ticket.ID = 1;
                _tickets.Add(ticket);
            }
            return ticket;
        }

        public static void AddList(List<Ticket> tickets)
        {
            foreach(Ticket ticket in tickets)
            {
                _tickets.Add(ticket);
            }
        }

        public static Ticket Get(int id, string firstName, string lastName)
        {
            return _tickets.FirstOrDefault(e => e.ID == id || (e.FirstName == firstName && e.LastName == lastName && e.FirstName != "AUTO-PICK"));
        }

        public static List<Ticket> AddRandom(int numberOfTickets)
        {
            List<Ticket> tickets = new List<Ticket>();
            int id = _tickets.Max(e => e.ID) + 1;
            for (int i = 1; i <= numberOfTickets; i++)
            {
                Ticket ticket = new Ticket { Numbers = RandomNumbers() , PowerBall = rand.Next(1,26), ID= id, FirstName="AUTO-PICK"};
                tickets.Add(ticket);
                id++;
            }
            return tickets;
        }

        private static int[] RandomNumbers()
        {
            bool distinct = false;
            int[] randoms = new int[5];
            while(!distinct)
            {
                randoms[0] = rand.Next(1, 70);
                randoms[1] = rand.Next(1, 70);
                randoms[2] = rand.Next(1, 70);
                randoms[3] = rand.Next(1, 70);
                randoms[4] = rand.Next(1, 70);

                if(randoms.Distinct().Count() == 5)
                {
                    distinct = true;
                }
            }
            return randoms;
        }
    }
}