using ClassyChess1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*        public int UserID { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public string Email { get; set; }
public int UserType { get; set; } = 1;
public bool Newsletter { get; set; } = false; */

namespace ClassyChess1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListUser()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel { FirstName = "John", LastName = "Kyker", Email = "44642@nelnet.net", UserType = 2, Newsletter = true });
                return View(users);
        }

        public ActionResult MakeUser()
        {
            return View();
        }

        public ActionResult DeleteUser()
        {
            return View();
        }

        public ActionResult EditUser()
        {
            return View();
        }
    }
}