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
                data2.Add(new DataSource() { x = 0, xval = "AUDI", yval = 1});
                data2.Add(new DataSource() { x = 1, xval = "BMW", yval = 5 });
                data2.Add(new DataSource() { x = 2, xval = "BUICK", yval = -1 });
                data2.Add(new DataSource() { x = 3, xval = "CETROEN", yval = -6 });
                data2.Add(new DataSource() { x = 4, xval = "CHEVROLET", yval = 0 });
                data2.Add(new DataSource() { x = 5, xval = "FIAT", yval = 1 });
                data2.Add(new DataSource() { x = 6, xval = "FORD", yval = -2 });
                data2.Add(new DataSource() { x = 7, xval = "HONDA", yval = 7 });
                data2.Add(new DataSource() { x = 8, xval = "HYUNDAI", yval = -9 });
                data2.Add(new DataSource() { x = 9, xval = "JEEP", yval = 0 });
                data2.Add(new DataSource() { x = 10, xval = "KIA", yval = -10 });
                data2.Add(new DataSource() { x = 11, xval = "MAZDA", yval = 3 });
                return data2;
            }
        }
    }
}
