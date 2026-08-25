using System;
using System.Collections.Generic;
using System.Linq;
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser.Controllers.TreeView
{
    public partial class TreeViewController : Controller
    {
        public IActionResult Virtualization()
        {
            ViewBag.data = new TreeViewVirtualization().GetVirtualizationData();
            return View();
        }
    }
}

