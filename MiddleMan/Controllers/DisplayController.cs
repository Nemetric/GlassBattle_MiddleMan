using MiddleMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiddleMan.Controllers
{
    public class DisplayController : Controller
    {
        // GET: Display
        public ActionResult WhatNext(int Id)
        {
            //open Json text file
            //iterate through the items in Json
            //and find the item where ID == input ID
            //once found return that item
            //else send new device
            var r = new Devices(); 
            r.Id = 1;
            r.Color = "blue";
            r.FriendlyName = "asdf";
            return Json(r,JsonRequestBehavior.AllowGet );
        }
    }
}