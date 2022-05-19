using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lapidandopedrabruta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tratamentos()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}