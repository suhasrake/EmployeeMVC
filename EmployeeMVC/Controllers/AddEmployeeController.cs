using EmployeeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class AddEmployeeController : Controller
    {
        // GET: AddEmployee
        CSLERPEntities Db = new CSLERPEntities();
        public ActionResult Addemployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployeeResult(Employee model)    //[Bind(Include ="EmployeeID,Name,PhoneNo,EmailID")]
        {            
            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>ID :</b> " + model.EmployeeID + "<br/>");
            sbInterest.Append("<b>Name :</b> " + model.Name + "<br/>");
            sbInterest.Append("<b>Phno :</b> " + model.PhoneNo + "<br/>");
            sbInterest.Append("<b>EmailID :</b> " + model.EmailID);
        
            if (ModelState.IsValid)
            {
                try
                {
                    Db.Employees.Add(model);
                    Db.SaveChanges();
                }
              catch(Exception ex)
                {

                }                
            }
            return Content(sbInterest.ToString());
        }

        

        public ActionResult ShowEmployee(int id)    //[Bind(Include ="EmployeeID,Name,PhoneNo,EmailID")]
        {
            CSLERPEntities contxt = new CSLERPEntities();
            Employee ba = contxt.Employees.Where(x => x.RowID== id).FirstOrDefault();
            return View(ba);
            
        }




        //[HttpPost] //this works too for single values
        //public JsonResult AjaxMethod(Employee emp )
        //{
        //    Employee person = new Employee();
        //    {
        //        person.EmployeeID = emp.EmployeeID;
        //        person.Name = emp.Name;
        //        person.PhoneNo = emp.PhoneNo;
        //        person.EmailID = emp.EmailID;

        //    };
        //    return Json(person);
        //}
    }
}