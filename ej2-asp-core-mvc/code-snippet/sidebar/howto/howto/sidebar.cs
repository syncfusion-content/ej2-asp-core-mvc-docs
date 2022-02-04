using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public partial class SidebarController : Controller
    {
        public IActionResult sidebar()
        {
            List<object> data = new List<object>();
            data.Add(new { text = "Home", id = "list-01" });
            data.Add(new { text = "Offers", id = "list-02" });
            data.Add(new { text = "Support", id = "list-03" });
            data.Add(new { text = "Logout", id = "list-04" });
            ViewBag.dataSource = data;
            return View();
        }
    }
}