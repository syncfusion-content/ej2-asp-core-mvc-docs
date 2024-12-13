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
                text = "Unread"
            });
            items.Add(new
            {
                text = "Has Attachments"
            });
            items.Add(new
            {
                text = "Categorized"
            });
            items.Add(new
            {
                separator = "True"
            });
            items.Add(new
            {
                text = "Important"
            });
            items.Add(new
            {
                 text = "More Filters"
            });
            ViewBag.items = items;
            return View();
        }
    }
}