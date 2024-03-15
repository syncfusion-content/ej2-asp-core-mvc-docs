using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MultiSelectController : Controller
    {
        public ActionResult object()
        {
            ViewBag.data = new Record().RecordModelList();
            ViewBag.value = new object[] { new { ID = "id5", Text = "Item 5" }, new { ID = "id14", Text = "Item 14" }, new { ID = "id25", Text = "Item 25" } };
            return View();
        }
    }
}