using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public ActionResult UIComponents()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Option 1"
            });
            menuItems.Add(new
            {
                text = "Option 2"
            });
            menuItems.Add(new
            {
                text = "Option 3"
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}