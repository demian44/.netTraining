﻿using System.Web;
using System.Web.Mvc;
using Filters.Filters;

namespace Filters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new VerifySessionFilter());
        }
    }
}
