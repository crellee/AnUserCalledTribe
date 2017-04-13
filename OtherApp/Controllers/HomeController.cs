using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using OtherApp.Models;
using System.Xml;
using System.Text;

namespace OtherApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*
             * laver .edmx fil af context
             * 
             * 
            using (var ctx = new OtherAppContext())
            {
                using (var writer = new XmlTextWriter(@"C:\Users\b022356\Desktop\Model.edmx", Encoding.Default))
                {
                    EdmxWriter.WriteEdmx(ctx, writer);
                }
            }
            */
            /*
             * en anden note: Enable-Migrations –EnableAutomaticMigrations 
             * update-database 
             * 
             */

            return View();
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