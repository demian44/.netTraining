using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppliactoinInsights.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceWarning("Index - Slow response - Test.......");
            return View();
        }

        public ActionResult About()
        {
            System.Diagnostics.Trace.TraceWarning("About - Slow response - Test.......");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            System.Diagnostics.Trace.TraceWarning("Trace - Slow response - Test.......");
            var telemetry = new Microsoft.ApplicationInsights.TelemetryClient();
            telemetry.TrackTrace("telemetry - Slow response - database01");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}