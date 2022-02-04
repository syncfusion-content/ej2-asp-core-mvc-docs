using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ListBoxController : Controller
    {
        public IActionResult sorting()
        {
            ViewBag.data = new string[] { "Austrlia", "Bermuda", "Canada", "Cameroon", "Denmark", "France", "Finland", "Germany", "Hong kong" };
            ViewBag.value = "Descending";
            return View();
        }
    }
}