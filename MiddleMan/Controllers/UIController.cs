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
            //take the ajax hex code and ID and validate it
            //if it is not valid return status failure
            //open json test file
            //find the ID where the ID == the ajax ID sent
            //change the hex code sent with the ajax next to that ID
            //save the json file
            //return staus success
            //put the hex code in the json with the corresponding ID
            var retVal = new {
                status = "success",
                message = ""
            };

            return Json(retVal,JsonRequestBehavior.AllowGet );
        }
    }
}