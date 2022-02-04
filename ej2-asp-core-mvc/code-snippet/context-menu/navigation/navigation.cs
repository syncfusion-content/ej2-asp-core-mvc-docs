using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public IActionResult Navigation()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Flipkart",
                iconCss = "e-cart-icon e-link",
                url= "https://www.google.co.in/search?q=flipkart"
            });
            items.Add(new
            {
                text = "Amazon",
                iconCss = "e-cart-icon e-link",
                url= "https://www.google.co.in/search?q=amazon"
            });
            items.Add(new
            {
                text = "Snapdeal",
                iconCss = "e-cart-icon e-link",
                url= "https://www.google.co.in/search?q=snapdeal"
            });
            ViewBag.items = items;
            return View();
        }
    }
}