using System.Diagnostics;
using CodeFirst.Two.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CodeFirst.Two.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.intSize = sizeof(int);
            ViewBag.intTestingClass = Marshal.SizeOf(typeof(TestingClass));
            ViewBag.booleanSize = sizeof(bool);

            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TestingClass
    {
        public bool ShowingHeader { get; set; }
        public bool ShowingBody { get; set; }
        public bool ShowingMenu { get; set; }
        public bool ShowingNavBar { get; set; }
    }
}
