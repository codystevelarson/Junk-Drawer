using RPSWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPSWebApp.Controllers
{
    public class HomeController : Controller
    {
        public static RPSGame game = new RPSGame();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Play(Player player)
        {
            GameOver gameOver = game.PlayGame(player);

            return View(gameOver);
        }

        [HttpGet]
        public ActionResult PlayAgain()
        {
            return RedirectToAction("Index");
        }
    }
}