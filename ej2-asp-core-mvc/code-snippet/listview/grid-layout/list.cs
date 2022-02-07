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
            string[] listdata = { "1","2", "3", "4", "5", "6", "7", "8", "9" };
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}