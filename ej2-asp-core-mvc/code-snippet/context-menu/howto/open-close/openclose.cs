using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public ActionResult OpenClose()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Cut"
            });
            menuItems.Add(new
            {
                text = "Copy"
            });
            menuItems.Add(new
            {
                text = "Paste"
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}