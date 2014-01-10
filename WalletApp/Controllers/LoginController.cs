using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WalletApp.DataAccess;

namespace WalletApp.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult index(LoginModel model) {

            if (ModelState.IsValid) {
                if (DAL.UserIsValid(model.Username,model.Password)) // Simulate data store
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false); // if true cookie still there
                    return RedirectToAction("index", "home");
                }
                else {
                    ModelState.AddModelError("","Invalid Username or Password");
                }
            }
            return View();
        
        }
    }
}
