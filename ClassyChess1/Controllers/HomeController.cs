using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassyChess1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sapphire Coffee Club description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sapphire Coffee Club contact page.";

            return View();
        }
    }
}