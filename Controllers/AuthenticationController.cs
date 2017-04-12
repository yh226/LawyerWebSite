using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LawyerWbSite.Controllers
{
    public class AuthenticationController : Controller
    {

        private LawyerOfficeContext_test db = new LawyerOfficeContext_test();
        // GET: Authentication
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DoLogin(Administrator admin)
        {
            
            if (IsValidUser(admin))
            {
                FormsAuthentication.SetAuthCookie(admin.Username, false);
                return RedirectToAction("Index", "home");
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                return View("Login");
            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");

        }

        public bool IsValidUser(Administrator admin)
        {
            var AdminList = db.Administrators.ToList();
            bool flag = false;
            for (int i=0; i<AdminList.Count;i++)
            {
                if(admin.Username == RemoveSpace(AdminList[i].Username) 
                    && admin.Password== RemoveSpace(AdminList[i].Password))
                {
                    flag = true;
                }
                
            }
            return flag;
        }

        public string RemoveSpace(string stringName)
        {
            char[] MyChar = { ' ', '-' };
            string NewString = stringName.TrimEnd(MyChar);

            return NewString;
        }
    }
}