using MiddleMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiddleMan.Controllers
{
    public class UIController : Controller
    {
        // GET: Display
        public ActionResult ChangeColor(int Id, string color)
        {
            string path = Server.MapPath("~/App_Data/HexColor.txt");
            string[] Color = { color };
            System.IO.File.WriteAllLines(path, Color);
            var retVal = new {
                status = "success",
                message = ""
            };

            return Json(retVal,JsonRequestBehavior.AllowGet );
        }
    }
}