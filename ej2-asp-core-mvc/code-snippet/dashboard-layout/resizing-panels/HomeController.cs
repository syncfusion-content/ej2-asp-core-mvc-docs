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
            public string[] handles { get; set; }
        }
        public ActionResult Index()
        {
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            modelValue.handles = new string[] { "e-south-east", "e-east", "e-west", "e-south-west", "e-south" };
            return View(modelValue);
        }
    }
}