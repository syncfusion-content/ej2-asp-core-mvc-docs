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
        List<object> Data = new List<object> {
            new { text = "Hennessey Venom", id = "list-01" },
            new { text = "Bugatti Chiron", id = "list-02" },
            new { text = "Bugatti Veyron Super Sport", id = "list-03" },
            new { text = "SSC Ultimate Aero", id = "list-04" },
            new { text = "Koenigsegg CCR", id = "list-05" },
            new { text = "McLaren F1", id = "list-06" },
            new { text = "Aston Martin One- 77", id = "list-07" },
            new { text = "Jaguar XJ220", id = "list-08" }
        ViewBag.data = Data;
        return View();
    }
}
}