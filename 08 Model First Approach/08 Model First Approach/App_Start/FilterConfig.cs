﻿using System.Web;
using System.Web.Mvc;

namespace _08_Model_First_Approach
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
