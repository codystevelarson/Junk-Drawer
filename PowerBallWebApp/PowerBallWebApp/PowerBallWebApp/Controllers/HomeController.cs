using PowerBallWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PowerBallWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ticket model)
        {
            if(ModelState.IsValid)
            {
                List<Ticket> tickets = new List<Ticket>()
                {
                    model
                };
                
                return View("Confirmation", tickets);
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult LookupTicket()
        {        
            return View();
        }

        [HttpPost]
        public ActionResult AutoCreate(int numberOfTickets)
        {
            List<Ticket> tickets = TicketRepository.AddRandom(numberOfTickets);
            TicketRepository.AddList(tickets);
            
            return View("Confirmation", tickets);
        }

        [HttpGet]
        public ActionResult DisplayTicket(Ticket ticket)
        {
            Ticket model = TicketRepository.Get(ticket.ID, ticket.FirstName, ticket.LastName);
            return View(model);
        }
    }
}