using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            Container container = new Container();
            this.ViewBag.Message = container;
            return View();
        }
    }

    public class Container
    {
        public string title;
        public string time;
        List<string> list;
    public Container()
        {
            title = "Titulo";
            time = "Time";
            list = new List<string> { "Back to Future", "120 min" };
        }
    }
}