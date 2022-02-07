using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.sparkData = DataSource.GetCategoryData();
            return View();
        }
        public class DataSource
        {
            public DateTime xDate;
            public double yval;
            public int x;
            public string xval;

            public static List<DataSource> GetCategoryData()
            {
                List<DataSource> data2 = new List<DataSource>();
                data2.Add(new DataSource() { x = 0, xval = "2005", yval = 20090440 });
                data2.Add(new DataSource() { x = 1, xval = "2006", yval = 20264080 });
                data2.Add(new DataSource() { x = 2, xval = "2007", yval = -20434180 });
                data2.Add(new DataSource() { x = 3, xval = "2008", yval = 21007310 });
                data2.Add(new DataSource() { x = 4, xval = "2009", yval = 21262640 });
                data2.Add(new DataSource() { x = 5, xval = "2010", yval = -21515750 });
                data2.Add(new DataSource() { x = 6, xval = "2011", yval = 21766710 });
                data2.Add(new DataSource() { x = 7, xval = "2012", yval = 22015580 });
                data2.Add(new DataSource() { x = 8, xval = "2013", yval = -22262500 });
                data2.Add(new DataSource() { x = 9, xval = "2014", yval = 22507620 });
                return data2;
            }
        }
    }
}
