using EmployeeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employee()
        {
            try
            {
                string uid = Session["Userid"].ToString();
            }
            catch(Exception ex)
            {
                return RedirectToAction("Login", "login");
            }
            //if (uid == "")
            //{
            //    ;
            //        }
            CSLERPEntities contxt = new CSLERPEntities();
            List<Employee> ba = contxt.Employees.OrderBy(x=>x.Name).ToList();
            return View(ba);
        }
    }
}