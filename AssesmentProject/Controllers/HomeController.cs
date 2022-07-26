using AssesmentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssesmentProject.Controllers
{
    
    public class HomeController : Controller
    {
#pragma warning disable CS0169 // The field 'HomeController.status' is never used
        Status status;
#pragma warning restore CS0169 // The field 'HomeController.status' is never used
        List<Status> statuses;
        public ActionResult Home()
        {
            statuses = new List<Status>();
            return View("Home");
        }
        public ActionResult state()
        {
            statuses = new List<Status>();

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    statuses.Add(new Status(i, "Nordea Bank"));   
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    statuses.Add(new Status(i, "Nordea"));
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    statuses.Add(new Status(i, "Bank"));
                }
            }


            return View("Home",statuses);
        }
    }
}