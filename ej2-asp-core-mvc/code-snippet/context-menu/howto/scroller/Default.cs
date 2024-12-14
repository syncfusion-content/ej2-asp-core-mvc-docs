using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public ActionResult Default()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "View",
                items = new List<object>()
                {
                    new { text = "Mobile" },
                    new { text = "Desktop Smaller" },
                    new { text = "Desktop Normal" },
                    new { text = "Desktop Bigger Smaller" },
                    new { text = "Desktop Bigger Normal" }
                }
            });
            menuItems.Add(new
            {
                text = "Refresh"
            });
            menuItems.Add(new
            {
                text = "Paste"
            });
            menuItems.Add(new
            {
                separator = true
            });
            menuItems.Add(new
            {
                text = "New"
            });
            menuItems.Add(new
            {
                text = "Personalize"
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}