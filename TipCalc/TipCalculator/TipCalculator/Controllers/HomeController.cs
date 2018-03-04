using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(TipCalc model)
        {
            if(ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}