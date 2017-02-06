using MiddleMan.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        //C:\Projects\GlassBattle\GlassBattle_MiddleMan\MiddleMan\HexColor.txt
                string path = Server.MapPath("~/App_Data/HexColor.txt");
                string path2 = Server.MapPath("~/App_Data/TextFromTheBox.txt");

            var inStream = new FileStream(path, FileMode.Open,
                               FileAccess.Read, FileShare.ReadWrite);
            var inStream2 = new FileStream(path2, FileMode.Open,
                               FileAccess.Read, FileShare.ReadWrite);

            var file = new System.IO.StreamReader(inStream, System.Text.Encoding.UTF8, true, 128);
            var file2 = new System.IO.StreamReader(inStream2, System.Text.Encoding.UTF8, true, 128);

            var r = new Devices(); 
            r.Id = 1;
            r.Color = file.ReadLine();
            r.FriendlyName = "3.14";
            r.Text = file2.ReadLine();
            return Json(r,JsonRequestBehavior.AllowGet );
        }
    }
}