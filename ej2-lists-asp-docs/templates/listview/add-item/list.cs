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
            listdata.Add(new { text= "Hennessey Venom", id= "1", icon= "delete-icon" });
            listdata.Add(new { text= "Bugatti Chiron", id= "2", icon= "delete-icon" });
            listdata.Add(new { text= "Bugatti Veyron Super Sport", id= "3", icon= "delete-icon" });
            listdata.Add(new { text= "Aston Martin One- 77", id= "4", icon= "delete-icon" });
            listdata.Add(new { text= "Jaguar XJ220", id= "list-5", icon= "delete-icon" });
            listdata.Add(new { text= "McLaren P1", id= "6", icon= "delete-icon" });
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}