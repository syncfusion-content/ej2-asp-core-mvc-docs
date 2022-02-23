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
            ViewBag.datetime = DataSource.GetDatetimeData();
            return View();
        }
        public class DataSource
        {
            public DateTime xDate;
            public double yval;
            public int x;
            public string xval;

            public static List<DataSource> GetDatetimeData()
            {
                List<DataSource> data1 = new List<DataSource>();
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 1), yval = 4  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 2), yval = 4.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 3), yval = 8  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 4), yval = 7  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 5), yval = 6  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 8), yval = 8  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 9), yval = 8  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 10), yval = 6.5 });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 11), yval = 4  });
                data1.Add(new DataSource() { xDate = new DateTime(2018, 1, 12), yval = 5.5 });
                return data1;                
            }
        }
    }
}
