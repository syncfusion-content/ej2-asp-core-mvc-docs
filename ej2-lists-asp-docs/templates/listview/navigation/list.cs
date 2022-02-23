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
            listdata.Add(new { name = "Google", url = "https://www.google.com" });
            listdata.Add(new { name = "Bing", url = "https://www.bing.com" });
            listdata.Add(new { name = "Yahoo", url = "https://www.yahoo.com" });
            listdata.Add(new { name = "Ask.com", url = "https://www.ask.com" });
            listdata.Add(new { name = "AOL.com", url = "https://www.aol.com"});
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}