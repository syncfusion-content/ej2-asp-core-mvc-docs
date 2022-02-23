using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SplitButtonController : Controller
    {
        public ActionResult ItemTemplate()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Edit"
            });
            items.Add(new
            {
                text = "Cut"
            });
            ViewBag.items = items;
            return View();
        }
    }
}