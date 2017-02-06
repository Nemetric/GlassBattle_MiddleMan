using MiddleMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiddleMan.Controllers;

namespace MiddleMan.Controllers
{
    public class UIController : Controller
    {
        // GET: Display
        public ActionResult ChangeColor(int Id, string color, string text)
        {
            string path = Server.MapPath("~/App_Data/HexColor.txt");
            string path2 = Server.MapPath("~/App_Data/TextFromTheBox.txt");
            string[] Color = { color };
            string[] TextBox = { text };
            System.IO.File.WriteAllLines(path, Color);
            System.IO.File.WriteAllLines(path2, TextBox);
            var retVal = new {
                status = "success",
                message = ""
            };
           
            return Json(retVal,JsonRequestBehavior.AllowGet );
        }
    } 
}