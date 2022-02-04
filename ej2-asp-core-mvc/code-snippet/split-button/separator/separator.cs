using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SplitButtonController : Controller
    {
        public ActionResult Separator()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Cut",
                iconCss = "e-sb-icons e-cut"
            });
            items.Add(new
            {
                text = "Copy",
                iconCss = "e-icons e-copy"
            });
            items.Add(new
            {
                text = "Paste",
                iconCss = "e-sb-icons e-paste"
            });
            items.Add(new
            {
                separator = true
            });
            items.Add(new
            {
                text = "Paste",
                iconCss = "e-sb-icons e-paste"
            });
            items.Add(new
            {
                text = "Paste Special",
                iconCss = "e-sb-icons e-pastespecial"
            });
            ViewBag.items = items;
            return View();
        }
    }
}