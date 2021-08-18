using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeMVC.Models;

namespace PracticeMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*public string Profile(int id ) 
          {
              string profile =string.Empty;
              if (id == 1)
              {
                  profile = "Employee 1 profile";

              }
              else if (id == 1)
              {
                  profile = "Employee 2 profile";

              }
              else {
                  profile = "No record found";
              }
              return  profile; 
          }*/
        public ActionResult Index()
        {
            var data = GetEmployeeDetail();
            return View(data);
        }
        public ActionResult GetEmployee(int id)
        {
            var Obj = GetEmployeeDetail().FirstOrDefault(x => x.Id == id);
            ViewBag.output = "";
            if (Obj == null)
            {
                ViewBag.output = "No employee with this id ";
            }
            return View(Obj);
        }
        private List<Employee> GetEmployeeDetail()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Anchal",
                    Address = "Indore",
                
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Tarun",
                    Address = "Bhopal "
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Anjali",
                    Address = "Jaipur"
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Saloni",
                    Address = "Ratlam"
                }
            };
        }
    }
}