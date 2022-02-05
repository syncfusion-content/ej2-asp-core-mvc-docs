using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public class spacingModel
        {
            public double[] cellSpacing { get; set; }
        }
        public ActionResult Index()
        {
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            return View(modelValue);
        }
    }
}