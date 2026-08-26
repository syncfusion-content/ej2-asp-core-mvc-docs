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
        public ActionResult summarytagtemplate()
        {
            ViewBag.data = new Record().RecordModelList();
            ViewBag.value = new Record().RecordModelList().Select(e => e.Text).ToArray();
            return View();
        }
    }
}