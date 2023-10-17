using ProjetoHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoHotel.Controllers
{
    public class ReservaController : Controller
    {
        public ActionResult Index() 
        {
            Suite suite1 = new Suite("Executiva", 2, 50.00M);
            Suite suite2 = new Suite("Premium", 4, 200.00M);

            List<Suite> suites = new List<Suite>();
            suites.Add(suite1);
            suites.Add(suite2);

            return View(suites);
        }
    }
}