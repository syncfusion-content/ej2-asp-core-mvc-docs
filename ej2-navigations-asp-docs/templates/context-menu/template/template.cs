using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public IActionResult Template()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Save as...  "
            });
            menuItems.Add(new
            {
                text = "View page source  "
            });
            menuItems.Add(new
            {
                text = "Inspect  "
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}