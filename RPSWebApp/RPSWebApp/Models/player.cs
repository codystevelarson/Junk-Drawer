using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPSWebApp.Models
{
    public class Player
    {
        public Choice Choice { get; set; }
        public GameResult Result { get; set; }
    }
}