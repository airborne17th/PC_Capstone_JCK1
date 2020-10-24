using ClassyChess1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.UserProcessor;

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

        public ActionResult Registration()
        {
            ViewBag.Message = "Sapphire Coffee Club Chess League Sign Up.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(UserModel model)
        {
            if (ModelState.IsValid)
            {
                int recordCreated = CreateUser(model.FirstName,
                    model.LastName,
                    model.Email, 
                    model.Password,
                    model.Newsletter);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(UserModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (DB_Entities db = new DB_Entities())
        //        {
        //            var obj = db.UserProfiles.Where(a => a.UserName.Equals(model.Email) && a.Password.Equals(model.Password)).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                Session["UserEmail"] = obj.UserEmail.ToString();
        //                Session["UserName"] = obj.UserName.ToString();
        //                return RedirectToAction("UserDashBoard");
        //            }
        //        }
        //    }
        //    return View(model);
        //}

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}