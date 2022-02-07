using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult customizetemplate()
        {
            List<object> listdata = new List<object>();
            listdata.Add(new {css= "facebook", socialMedia= "Facebook", id= "media1" }); 
            listdata.Add(new { css= "twitter", socialMedia= "Twitter", id= "media2" }); 
            listdata.Add(new { css= "tumblr", socialMedia= "Tumblr", id= "media4" }); 
            listdata.Add(new { css= "google-plus", socialMedia= "Google Plus", id= "media5" }); 
            listdata.Add(new { css= "skype", socialMedia= "Skype", id= "media6" }); 
            listdata.Add(new { css= "vimeo", socialMedia= "Vimeo", id= "media7" }); 
            listdata.Add(new { css= "instagram", socialMedia= "Instagram", id= "media8" });
            listdata.Add(new { css= "youtube", socialMedia= "YouTube", id= "media9" }); 
            ViewBag.dataSource = listdata;
            return View();
        }
    }
}