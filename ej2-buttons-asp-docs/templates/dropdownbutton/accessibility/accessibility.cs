using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DropDownButtonController : Controller
    {
        public ActionResult Accessibility()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Cut",
                iconCss = "e-db-icons e-cut"
            });
            items.Add(new
            {
                text = "Copy",
                iconCss = "e-icons e-copy"
            });
            items.Add(new
            {
                text = "Paste",
                iconCss = "e-db-icons e-paste"
            });
            items.Add(new
            {
                separator = "True"
            });
            items.Add(new
            {
                text = "Font",
                iconCss = "e-db-icons e-font"
            });
            items.Add(new
            {
                text = "Paragraph",
                iconCss = "e-db-icons e-paragraph"
            });
            ViewBag.items = items;
            return View();
        }
    }
}