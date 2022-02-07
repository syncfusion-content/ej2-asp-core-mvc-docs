using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult grouptemplate()
        {         
            List<object> listdata = new List<object>();
            listdata.Add(new {css= "facebook", socialMedia= "Facebook", category = "F" }); 
            listdata.Add(new { css= "twitter", socialMedia= "Twitter", category = "T" }); 
            listdata.Add(new { css= "tumblr", socialMedia= "Tumblr", category = "T" }); 
            listdata.Add(new { css= "instagram", socialMedia= "Instagram", category = "I" });
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}