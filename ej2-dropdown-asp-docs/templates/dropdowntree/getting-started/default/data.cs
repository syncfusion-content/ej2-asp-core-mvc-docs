using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DropDownTree.Models;
using Syncfusion.EJ2.DropDowns;

namespace DropDownTree.Controllers
{
    public class DropDownTreeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}