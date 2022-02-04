using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public IActionResult Dialog()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Back"
            });
            menuItems.Add(new
            {
                text = "Forward"
            });
            menuItems.Add(new
            {
                text = "Reload"
            });
            menuItems.Add(new
            {
                separator= true
            });
            menuItems.Add(new
            {
                text = "Save As..."
            });
            menuItems.Add(new
            {
                text = "Print"
            });
            menuItems.Add(new
            {
                text = "Cast"
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}