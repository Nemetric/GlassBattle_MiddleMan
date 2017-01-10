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
            var r = new Devices(); 
            r.Id = 1;
            r.Color = "blue";
            r.FriendlyName = "asdf";
            return Json(r,JsonRequestBehavior.AllowGet );
        }
    }
}