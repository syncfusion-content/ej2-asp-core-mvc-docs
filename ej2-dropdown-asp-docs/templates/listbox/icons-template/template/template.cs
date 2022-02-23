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
        public IActionResult template()
        {
           List<object> Data = new List<object>{
            new { Text="JavaScript", Pic="javascript", Description="It is a lightweight interpreted or JIT-compiled programming language." },
            new { Text="TypeScript", Pic="typeScript", Description="It is a typed superset of Javascript that compiles to plain JavaScript." },
            new { Text="Angular", Pic="angular", Description="It is a TypeScript-based open-source web application framework." },
            new { Text="React", Pic="react", Description="A JavaScript library for building user interfaces. It can also render on the server using Node." },
            new { Text="Vue", Pic="vue", Description="A progressive framework for building user interfaces. it is incrementally adoptable."}
        };
            ViewBag.data = Data;
            return View();
        }
    }
}