using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebSecurityDemo.Models;
namespace WebSecurityDemo.Content
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginInfo x) {
            if (ModelState.IsValid && x.UN=="abc"&& x.PW == "abc") {
                FormsAuthentication.SetAuthCookie(x.UN, false);
                return RedirectToAction("Index", "Home");
            }
            
            else {
                return View(x);
            }
        }

    }
}