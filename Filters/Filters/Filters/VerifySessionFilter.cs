using System.Web;
using System.Web.Mvc;
using Filters.Controllers;

namespace Filters.Filters
{
    public class VerifySessionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated &&
                !(filterContext.Controller is AccountController))
            {
                filterContext.HttpContext.Response.Redirect("/Account/Login");
            }
            else if (HttpContext.Current.User.Identity.IsAuthenticated &&
                filterContext.Controller is AccountController &&
                filterContext.ActionDescriptor.ActionName != "LogOff")
            {
                filterContext.HttpContext.Response.Redirect("/Home", false);
            }

            base.OnActionExecuting(filterContext);
        }
    }
}