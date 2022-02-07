using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult list()
        {   
           List<object> listdata = new List<object>();
            listdata.Add(new
            {
                text = "Hennessey Venom",
                id = "list-01"

            }); listdata.Add(new
            {
                text = "Bugatti Chiron",
                id = "list-02"

            }); listdata.Add(new
            {
                text = "Bugatti Veyron Super Sport",
                id = "list-03"

            }); listdata.Add(new
            {
                text = "SSC Ultimate Aero",
                id = "list-04"

            }); listdata.Add(new
            {
                text = "Koenigsegg CCR",
                id = "list-05"

            }); listdata.Add(new
            {
                text = "McLaren F1",
                id = "list-06"
            }); listdata.Add(new
            {
                text = "Aston Martin One- 77",
                id = "list-07"
            }); listdata.Add(new
            {
                text = "Jaguar XJ220",
                id = "list-08"
            });
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}