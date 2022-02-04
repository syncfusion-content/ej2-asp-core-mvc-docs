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
        public IActionResult grouping()
        {
            List<object> Data = new List<object> {
            new { Vegetable = "Cabbage", Category = "Leafy and Salad", Id = "item1" },
            new { Vegetable = "Spinach", Category = "Leafy and Salad", Id = "item2" },
            new { Vegetable = "Wheat grass", Category = "Leafy and Salad", Id = "item3" },
            new { Vegetable = "Yarrow", Category = "Leafy and Salad", Id = "item4" },
            new { Vegetable = "Pumpkins", Category = "Leafy and Salad", Id = "item5" },
            new { Vegetable = "Chickpea", Category = "Beans", Id = "item6" },
            new { Vegetable = "Green bean", Category = "Beans", Id = "item7" },
            new { Vegetable = "Horse gram", Category = "Beans", Id = "item8" },
            new { Vegetable = "Garlic", Category = "Bulb and Stem", Id = "item9" },
            new { Vegetable = "Nopal", Category = "Bulb and Stem", Id = "item10" },
            new { Vegetable = "Onion", Category = "Bulb and Stem", Id = "item11" }
            };
            ViewBag.data = Data;
            return View();
        }
    }
}