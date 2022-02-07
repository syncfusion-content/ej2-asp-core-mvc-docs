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
            ViewBag.data = DataSource.GetData();
            return View();
        }
        public class DataSource
        {
            public DateTime xDate;
            public double yval;
            public int x;
            public string xval;

            public static List<DataSource> GetData()
            {
                List<DataSource> data3 = new List<DataSource>();
                data3.Add(new DataSource() { xval = "Mon", yval = 3});
                data3.Add(new DataSource() { xval = "Tue", yval = 5});
                data3.Add(new DataSource() { xval = "Wed", yval = 2});
                data3.Add(new DataSource() { xval = "Thu", yval = 4});
                data3.Add(new DataSource() { xval = "Fri", yval = 6});
                return data3;
            }
        }
    }
}
