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
                data3.Add(new DataSource() { x = 1, yval = 190});
                data3.Add(new DataSource() { x = 2, yval = 165});
                data3.Add(new DataSource() { x = 3, yval = 158});
                data3.Add(new DataSource() { x = 4, yval = 175});
                data3.Add(new DataSource() { x = 5, yval = 200});
                data3.Add(new DataSource() { x = 6, yval = 180});
                data3.Add(new DataSource() { x = 7, yval = 210});
                return data3;
            }
        }
    }
}
