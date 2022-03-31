using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UICorrespondenceSystem.DataAccess;
using UICorrespondenceSystem.Models;
using Correspondence = UICorrespondenceSystem.Models.Correspondence;

namespace UICorrespondenceSystem.Controllers
{
    public class HomeController : Controller
    {
        COR_DEVEntities db = new COR_DEVEntities();
        public ActionResult Index()
        {
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

        public ActionResult New()
        {
            ViewBag.Message = "New Correspondence page";
            return View();
        }

        [HttpPost]
        public ActionResult New(Correspondence correspondence)
        {
            DataAccess.Correspondence obj = new DataAccess.Correspondence();
            obj.Serial_Number = correspondence.Serial_Number;
            obj.Subject = correspondence.Subject;
            obj.Sender_Creation_Date = correspondence.Correspondence_Date;
            obj.Received_Date = correspondence.Received_Date;
            obj.Sender_Type = Convert.ToByte(correspondence.Sender_Type);
            db.Correspondences.Add(obj);
            db.SaveChanges();
            return View(correspondence);
        }

        [HttpPost]
        public JsonResult Index(string Prefix)
        {
            //Note : you can bind same list from database  
            List<Organization> ObjList = new List<Organization>()
            {

                new Organization {Id=1,Name="Org1" },
                new Organization {Id=2,Name="Org12" },
                new Organization {Id=3,Name="Org13" },
                new Organization {Id=4,Name="Org14" },
                new Organization {Id=5,Name="Org15" },
                new Organization {Id=6,Name="Org16" },
                new Organization {Id=7,Name="Org17" }

        };
            //Searching records from list using LINQ query  
            var Name = (from N in ObjList
                        where N.Name.ToLower().Contains(Prefix.ToLower())
                        select new { N.Name });
            return Json(Name, JsonRequestBehavior.AllowGet);
        }
    }
}