using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DropDownButtonController : Controller
    {
        public ActionResult Default()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Selection",
                iconCss = "e-icons e-list-unordered"
            });
            items.Add(new
            {
                text = "Yes / No",
                iconCss = "e-icons e-check-box"
            });
            items.Add(new
            {
                text = "Text",
                iconCss = "e-icons e-caption"
            });
            items.Add(new
            {
                text = "None",
                iconCss = 'e-icons e-mouse-pointer'
            });
            ViewBag.items = items;
            return View();
        }
    }
}