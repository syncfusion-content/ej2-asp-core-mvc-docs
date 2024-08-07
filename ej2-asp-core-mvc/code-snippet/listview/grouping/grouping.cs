﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult grouping()
        {  List<object> listdata = new List<object>();
            listdata.Add(new
            {
                text = "Audi A4",
                id = "9bdb",
                category = "Audi"
            }); listdata.Add(new
            {
                text = "Audi A5",
                id = "4589",
                category = "Audi"
            }); listdata.Add(new
            {
                text = "BMW 501",
                id = "f849",
                category = "BMW"
            }); listdata.Add(new
            {
                text = "BMW 502",
                id = "7aff",
                category = "BMW"
            });
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}