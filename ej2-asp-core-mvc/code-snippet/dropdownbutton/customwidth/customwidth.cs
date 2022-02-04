using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Buttons;
namespace EJ2CoreSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult DropDownButton()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Find"
            });
            items.Add(new
            {
                text = "Replace"
            });
            items.Add(new
            {
                text = "Go To"
            });
            items.Add(new
            {
                text = "Go To Special"
            });
            ViewBag.items = items;
            return View();
        }
    }
}