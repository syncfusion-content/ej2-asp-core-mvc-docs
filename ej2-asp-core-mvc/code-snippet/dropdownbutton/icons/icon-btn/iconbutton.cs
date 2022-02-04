using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DropDownButtonController : Controller
    {
        public ActionResult IconButton()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Edit"
            });
            items.Add(new
            {
                text = "Delete"
            });
            items.Add(new
            {
                text = "Mark as Read"
            });
            items.Add(new
            {
                text = "Like Message"
            });
            ViewBag.items = items;
            return View();
        }
    }
}