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
            ViewBag.category = DataSource.GetCategoryData();
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
                data2.Add(new DataSource() { xval = "Robert" , yval = 60});
                data2.Add(new DataSource() { xval = "Andrew", yval = 65 });
                data2.Add(new DataSource() { xval = "Suyama", yval = 70 });
                data2.Add(new DataSource() { xval = "Michael", yval = 80 });
                data2.Add(new DataSource() { xval = "Janet", yval = 55 });
                data2.Add(new DataSource() { xval = "Davolio", yval = 90 });
                data2.Add(new DataSource() { xval = "Fuller", yval = 75 });
                data2.Add(new DataSource() { xval = "Nancy", yval = 85 });
                return data2;
            }
        }
    }
}
