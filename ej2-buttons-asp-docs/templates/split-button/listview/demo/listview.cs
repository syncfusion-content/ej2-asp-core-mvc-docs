using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.SplitButtons;

namespace EJ2CoreSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult SplitButton()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Cut",
                category = "Basic"
            });
            items.Add(new
            {
                text = "Copy",
                category = "Basic"
            });
            items.Add(new
            {
                text = "Paste",
                category = "Basic"
            });
            items.Add(new
            {
                text = "Paste as Formula",
                category = "Advanced"
            });
            items.Add(new
            {
                text = "Paste as Hyperlink",
                category = "Advanced"
            });
            ViewBag.items = items;
            return View();
        }
    }
}