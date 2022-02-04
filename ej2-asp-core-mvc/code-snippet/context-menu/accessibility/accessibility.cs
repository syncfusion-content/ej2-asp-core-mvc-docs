using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public IActionResult Accessibility()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Cut",
                iconCss = "cm-icons e-cut"
            });
            menuItems.Add(new
            {
                text = "Copy",
                iconCss = "e-cm-icons e-copy"
            });
            menuItems.Add(new
            {
                text = "Paste",
                iconCss = "cm-icons e-paste",
                items = new List<object>()
                {
                    new { text = "Paste Text", iconCss = "e-cm-icons e-pastetext" },
                    new { text = "Paste Special", iconCss = "e-cm-icons e-pastespecial" }
                }
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}