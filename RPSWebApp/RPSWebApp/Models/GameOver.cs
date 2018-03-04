using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPSWebApp.Models
{
    public class GameOver
    {
        public Player User { get; set; }
        public Player Computer { get; set; }
        public int Turns { get; set; }
    }
}