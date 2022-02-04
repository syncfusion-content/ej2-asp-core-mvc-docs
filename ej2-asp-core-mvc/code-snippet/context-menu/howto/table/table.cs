using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public ActionResult Table()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Cut",
                iconCss = "e-cm-icons e-cut"
            });
            menuItems.Add(new
            {
                text = "Copy",
                iconCss = "e-icons e-copy"
            });
            menuItems.Add(new
            {
                text = "Paste",
                iconCss = "e-cm-icons e-paste"
            });
            menuItems.Add(new
            {
                separator = true
            });
            menuItems.Add(new
            {
                text = "Link",
                iconCss = "e-icons e-link"
            });
            menuItems.Add(new
            {
                text = "Table",
                items = new List<object>()
                {
                    new { 
                        text = "Insert Table",
                    },
                    new {
                        separator = true
                    },
                    new {
                        text = "Insert"
                    }
                }
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}