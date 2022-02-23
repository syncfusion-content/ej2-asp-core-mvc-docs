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
        Countries model = new Countries();
        public ActionResult Index()
        {
            ViewBag.data = new Countries().CountriesList();
            model.Value = "Cameroon";
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Countries model)
        {
            ViewBag.data = new Countries().CountriesList();
            model.Value = model.Value;
            return View();

        }
    }
}