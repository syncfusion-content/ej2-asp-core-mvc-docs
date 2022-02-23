using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SplitButtonController : Controller
    {
        public ActionResult Rtl()
        {
            // define the array of JSON
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Autosum"
            });
            items.Add(new
            {
                text = "Average"
            });
            items.Add(new
            {
                text = "Count numbers"
            });
            items.Add(new
            {
                text = "Min"
            });
            items.Add(new
            {
                text = "Max"
            });
            ViewBag.items = items;
            return View();
        }
    }
}