using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class TabController : Controller
    {
        // GET: //
        public IActionResult DefaultFunctionalities()
        {
            ViewBag.headerText0 = new TabHeader { Text = "Grid1" };
            ViewBag.headerText1 = new TabHeader { Text = "Grid2" };
            return View();
        }
        public ActionResult PartialView1()
        {
        
            return PartialView();

        }

        public ActionResult PartialView2()
        {

            return PartialView();

        }

    }
}