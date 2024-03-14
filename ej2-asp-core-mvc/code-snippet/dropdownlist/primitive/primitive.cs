using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DropDownListController : Controller
    {
        public ActionResult primitive()
        {
            ViewBag.data = new string[]{ "Item 1" , "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10" };
            ViewBag.value = "Item 5";
            return View();
        }
    }
}