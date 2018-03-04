using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PowerBallWebApp.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Must enter all numbers!")]
        public int[] Numbers { get; set; } = new int[5];
        [Required(ErrorMessage ="Must enter powerball number")]
        public int PowerBall { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}