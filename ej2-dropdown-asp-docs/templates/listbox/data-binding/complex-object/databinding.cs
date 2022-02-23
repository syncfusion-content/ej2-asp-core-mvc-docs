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
        public IActionResult databinding()
        {
        List<object> Data = new List<object>
        {
            new { id = "game0", sports = new {Name = "Badminton" } },
            new { id = "game1", sports = new {Name = "Cricket" } },
            new { id = "game2", sports = new {Name = "Football" } },
            new { id = "game3", sports = new {Name = "Golf" } },
            new { id = "game4", sports = new {Name = "Tennis" } },
            new { id = "game5", sports = new {Name = "Basket Ball" } },
            new { id = "game6", sports = new {Name = "Base Ball" } },
            new { id = "game7", sports = new {Name = "Hockey" } }
        };
        ViewBag.data = Data;
        return View();
    }
}
}