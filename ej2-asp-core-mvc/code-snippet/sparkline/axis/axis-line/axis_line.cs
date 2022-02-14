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
            ViewBag.numeric = DataSource.GetNumericData();
            return View();
        }
        public class DataSource
        {
            public DateTime xDate;
            public double yval;
            public int x;
            public string xval;

            public static List<DataSource> GetNumericData()
            {
                List<DataSource> data3 = new List<DataSource>();
                data3.Add(new DataSource() { x = 0, yval = 50});
                data3.Add(new DataSource() { x = 1, yval = 30});
                data3.Add(new DataSource() { x = 2, yval = 20});
                data3.Add(new DataSource() { x = 3, yval = 30});
                data3.Add(new DataSource() { x = 4, yval = 50});
                data3.Add(new DataSource() { x = 5, yval = 40});
                data3.Add(new DataSource() { x = 6, yval = 20});
                data3.Add(new DataSource() { x = 7, yval = 10 });
                data3.Add(new DataSource() { x = 8, yval = 30 });
                data3.Add(new DataSource() { x = 9, yval = 10 });
                data3.Add(new DataSource() { x = 10, yval = 40 });
                return data3;
            }
        }
    }
}
