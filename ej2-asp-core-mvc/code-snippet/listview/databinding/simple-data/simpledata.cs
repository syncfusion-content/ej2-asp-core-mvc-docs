using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult simpledata()
        {
            ViewBag.dataSource = new string[] { "Artwork", "Abstract", "Modern Painting", "Ceramics", "Animation Art", "Oil Painting" };
            return View();
        }
    }
}