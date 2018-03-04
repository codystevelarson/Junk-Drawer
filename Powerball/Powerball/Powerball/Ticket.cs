using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] NumberPicks { get; set; } = new int[5];
        public int Powerball { get; set; }

    }
}
