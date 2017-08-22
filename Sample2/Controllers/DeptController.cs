using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample2.Models;

namespace Sample2.Controllers
{
    public class DeptController : Controller
    {
        //
        // GET: /Dept/

        public ActionResult Index()
        {
            TESTEntities model = new TESTEntities();
            List<tblDepartment> department= model.tblDepartments.ToList();
            return View(department);
        }
       

    }
}
