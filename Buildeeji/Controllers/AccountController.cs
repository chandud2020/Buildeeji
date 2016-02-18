using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Buildeeji.Models.EntityManager;
using Buildeeji.ViewModel;



namespace Buildeeji.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserSignUpView USView)
        {
            if (ModelState.IsValid)
            {
                UserManager BEUserManager = new UserManager();
                if (!BEUserManager.IsLoginNameExists(USView.LoginName))
                {
                    BEUserManager.AddUserAccount(USView);
                    FormsAuthentication.SetAuthCookie(USView.FirstName, false);
                    return RedirectToAction("Welcome", "Home");
                }
                else
                    ModelState.AddModelError("", "Login name already taken.");
                
                
            }
            return View();
        }
    }
}