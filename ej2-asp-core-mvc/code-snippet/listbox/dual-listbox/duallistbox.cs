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
        public IActionResult duallistbox()
        {
            ViewBag.groupA = new string[] { "Austrlia", "Bermuda", "Canada", "Cameroon", "Denmark", "France", "Finland", "Germany", "Hong kong" };
            ViewBag.groupB = new string[] { "India", "Italy", "Japan", "Mexico", "Norway", "Poland", "Switzerland", "United Kingdom", "United States" };
            ViewBag.items = new string[] { "moveUp", "moveDown", "moveTo", "moveFrom", "moveAllTo", "moveAllFrom" };
            return View();
        }
    }
}