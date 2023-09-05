using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult list()
        {   
            List<object> data = new List<object>();
            data.Add(new { text = "Hennessey Venom", id = "list-01", htmlAttributes = new Dictionary<string, object>() { { "class", "e-high" } } });
            data.Add(new { text = "Bugatti Chiron", id = "list-02", htmlAttributes = new Dictionary<string, object>() { { "class", "e-moderate" } } });
            data.Add(new { text = "Bugatti Veyron Super Sport", id = "list-03", htmlAttributes = new Dictionary<string, object>() { { "class", "e-normal" } } });
            data.Add(new { text = "SSC Ultimate Aero", id = "list-04", htmlAttributes = new Dictionary<string, object>() { { "class", "e-moderate" } } });
            data.Add(new { text = "Koenigsegg CCR", id = "list-05", htmlAttributes = new Dictionary<string, object>() { { "class", "e-normal" } } });
            data.Add(new { text = "McLaren F1", id = "list-06", htmlAttributes = new Dictionary<string, object>() { { "class", "e-high" } } });
            data.Add(new { text = "Aston Martin One- 77", id = "list-07", htmlAttributes = new Dictionary<string, object>() { { "class", "e-moderate" } } });
            ViewBag.dataSource = data;
            return View();
        }       
    }
}