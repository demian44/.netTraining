using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            // [#TEMPORAL CHANGE - PLEASE RESET]
            TestClass testClass = new TestClass
            {
                Id = 0,
                Name = "Demian",
                Surname = "Boullon"
            };
            return View(testClass);
        }
    }


}