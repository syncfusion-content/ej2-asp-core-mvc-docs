using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public partial class ScheduleController : Controller
    {
        public ActionResult custom-timecells()
        {
            ViewBag.datasource = new ScheduleData().GetScheduleData();
            return View();
        }
    }
}