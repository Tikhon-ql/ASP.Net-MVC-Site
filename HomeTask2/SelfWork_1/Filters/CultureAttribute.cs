using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SelfWork_1.Filters
{
    public class CultureAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string cultureName = "";
            HttpCookie cookie = filterContext.HttpContext.Request.Cookies["lang"];
            if (cookie != null)
                cultureName = cookie.Value;
            else
                cultureName = "ru";
            List<string> cultures = new List<string> { "ru", "en" };
            if (!cultures.Contains(cultureName))
                cultureName = "ru";
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cultureName);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }
    }
}