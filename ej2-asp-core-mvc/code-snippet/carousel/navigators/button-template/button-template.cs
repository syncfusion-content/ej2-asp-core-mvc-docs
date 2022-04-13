using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class AccordionController : Controller
    {
        // GET: //
        public IActionResult DefaultFunctionalities()
        {
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