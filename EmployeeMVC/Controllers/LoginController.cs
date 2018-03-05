using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVC.Models;
using System.Web.Security;

namespace EmployeeMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        CSLERPEntities Db = new CSLERPEntities();
        public ActionResult Login()
        {
            CSLERPEntities context = new Models.CSLERPEntities();
            List<ERPUser> users = context.ERPUsers.ToList();
            return View(users);

        }

        public ActionResult LogOut()
        {
            Session.Clear();
            //FormsAuthentication.SignOut();
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.Buffer = true;
            //Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            //Response.Expires = -1000;
            //Response.CacheControl = "no-cache";
            //Response.Redirect("login.aspx", true);
            return RedirectToAction("Login", "login");
          
        }

        public ActionResult CheckLogin(string UID, string Pass)
        {
            
            string responce = "YN";
            var Check = Db.ERPUsers.Where(W => W.UserID == UID && W.Password == Pass).FirstOrDefault();
            if (Check != null)
            {
                Session["Userid"] = UID;
                responce = "Y";
            }
            
            return Content(responce);
        }
    }
}