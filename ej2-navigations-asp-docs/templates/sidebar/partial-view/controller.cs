using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public partial class SidebarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContextMenu()
        {
            return View();
        }
        public IActionResult Accordion()
        {
            return View();
        }
        public IActionResult Card()
        {
            return View();
        }
        public IActionResult Avatar()
        {
            return View();
        }
        public IActionResult Splitter()
        {
            return View();
        }
        public IActionResult InputMask()
        {
            return View();
        }
        public IActionResult TextBox()
        {
            return View();
        }
    }
}