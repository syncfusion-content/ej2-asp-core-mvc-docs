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
        public ActionResult arrayofstrings()
        {
            ViewBag.data = new string[] { "Badminton", "Basketball", "Cricket", "Football", "Golf", "Gymnastics", "Hockey", "Tennis" };
            return View();
        }
    }
}