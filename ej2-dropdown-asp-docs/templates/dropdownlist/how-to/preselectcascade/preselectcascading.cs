using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DropDownListController : Controller
    {
        public ActionResult preselectcascade()
        {
            ViewBag.state = new State().StateList();
            ViewBag.country = new Country().CountryList();
            ViewBag.cities = new Cities().CitiesList();
            ViewBag.popupHeight = "auto";
            return View();
        }
    }
}