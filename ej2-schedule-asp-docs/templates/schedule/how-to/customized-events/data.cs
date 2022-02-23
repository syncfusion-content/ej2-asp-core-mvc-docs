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
        public ActionResult customized-events()
        {
            ViewBag.datasource = new ScheduleData().GetScheduleData();
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Month },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Agenda }
            };
            ViewBag.view = viewOption;
            return View();
        }
    }
}