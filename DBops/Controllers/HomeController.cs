using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBops.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBForDBopsEntities dBopsEntities = new DBForDBopsEntities();
            var res = dBopsEntities.namedetails.ToList();

            return View("TestDbConnectivity",res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}