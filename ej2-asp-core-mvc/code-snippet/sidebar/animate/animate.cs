using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public partial class SidebarController : Controller
    {
        public IActionResult animate()
        {
            return View();
        }
    }
}