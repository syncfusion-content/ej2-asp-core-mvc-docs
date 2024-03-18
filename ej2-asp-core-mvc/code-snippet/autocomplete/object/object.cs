using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AutoCompleteController : Controller
    {
        public ActionResult object()
        {
            ViewBag.data = new Record().RecordModelList();
            ViewBag.value = new { ID = "id5", Text = "Item 5" };
            return View();
        }
    }
}