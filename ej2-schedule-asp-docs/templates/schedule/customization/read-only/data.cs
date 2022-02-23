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
        public IActionResult read-only()
        {
            ViewBag.datasource = new ScheduleData().GetReadonlyEventsData();
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.WorkWeek }
            };
            ViewBag.view = viewOption;
            return View();
        }
    }
}
