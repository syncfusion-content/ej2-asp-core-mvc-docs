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
        State model = new State();
        public ActionResult Index()
        {
            ViewBag.state = new State().StateList();
            ViewBag.country = new Country().CountryList();
            ViewBag.popupHeight = "auto";
            model.CountryId = "2";
            model.StateId = "105";
            return View(model);
        }
    }
}