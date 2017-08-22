using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample2.Models;

namespace Sample2.Controllers
{
    public class EmpController : Controller
    {
        //
        // GET: /Emp/

        public ActionResult Index(int id)
        {
            TESTEntities model = new TESTEntities();
            List<tblEmployee> emplist = model.tblEmployees.Where(a => a.DepartmentId == id).ToList();
            return View(emplist);
        }

        public ActionResult Index1(int id)
        {
            TESTEntities model = new TESTEntities();
            tblEmployee emplist = model.tblEmployees.Where(a => a.EmployeeId == id).Single();
            return View(emplist);
        }

    }
}
