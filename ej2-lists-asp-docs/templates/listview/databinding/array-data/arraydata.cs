using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult arraydata()
        {
            List<object> listdata = new List<object>();
            listdata.Add(new
            {
                Name = "Display",
                id = "list-01"

            }); listdata.Add(new
            {
                Name = "Notification",
                id = "list-02"

            }); listdata.Add(new
            {
                Name = "Sound",
                id = "list-03"

            }); listdata.Add(new
            {
                Name = "Apps",
                id = "list-04"

            }); listdata.Add(new
            {
                Name = "Storage",
                id = "list-05"

            }); listdata.Add(new
            {
                Name = "Battery",
                id = "list-06"
            });
            
            ViewBag.dataSource = listdata;
            return View();
        }
    }
}