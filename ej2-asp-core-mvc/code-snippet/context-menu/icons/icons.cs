using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public IActionResult Icons()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Cut",
                iconCss = "e-cm-icons e-cut"
            });
            items.Add(new
            {
                text = "Copy",
                iconCss = "e-icons e-copy"
            });
            items.Add(new
            {
                text = "Paste",
                iconCss = "e-cm-icons e-paste"
            });
            ViewBag.items = items;
            return View();
        }
    }
}