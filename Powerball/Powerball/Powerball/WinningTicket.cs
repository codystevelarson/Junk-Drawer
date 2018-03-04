using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerball
{
    public class WinningTicket
    {
        public Ticket Ticket { get; set; }
        public int MatchCount { get; }

        public WinningTicket(Ticket t, int macthCount)
        {
            Ticket = t;
            MatchCount = macthCount;
        }
    }
}
