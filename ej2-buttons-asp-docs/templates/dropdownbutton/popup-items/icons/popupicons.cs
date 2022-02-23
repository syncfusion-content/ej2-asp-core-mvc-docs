using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DropDownButtonController : Controller
    {
        public ActionResult PopupIcons()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Edit",
                iconCss = "ddb-icons e-edit"
            });
            items.Add(new
            {
                text = "Delete",
                iconCss = "ddb-icons e-delete"
            });
            items.Add(new
            {
                text = "Mark as Read",
                iconCss = "ddb-icons e-read"
            });
            items.Add(new
            {
                text = "Like Message",
                iconCss = "e-icons e-like"
            });
            ViewBag.items = items;
            return View();
        }
    }
}