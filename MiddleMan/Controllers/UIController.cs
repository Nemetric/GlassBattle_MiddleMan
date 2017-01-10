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
            var retVal = new {
                status = "success",
                message = ""
            };

            return Json(retVal,JsonRequestBehavior.AllowGet );
        }
    }
}