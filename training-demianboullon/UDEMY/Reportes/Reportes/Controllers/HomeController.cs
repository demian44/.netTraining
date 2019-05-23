using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reportes.Models;

namespace Reportes.Controllers
{
    public class HomeController : Controller
    {
        Models.ModelFirstEntities DBS = new ModelFirstEntities();
        public ActionResult Student()
        {
            return View(DBS.Students.ToList());
        }
    }
}