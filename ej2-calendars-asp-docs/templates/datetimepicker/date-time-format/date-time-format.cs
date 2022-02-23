using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult DateTimeFormat()
        {
            ViewBag.value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,14);
            return View();
        }
    }
}
