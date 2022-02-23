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
        public IActionResult appointment-fields()
        {
            ViewBag.appointments = GetScheduleData();
            return View();
        }
        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Paris",
                StartTime = new DateTime(2018, 1, 28, 10, 0, 0),
                EndTime = new DateTime(2018, 1, 28, 12, 30, 0)
            });
            return appData;
        }
    }
    public class AppointmentData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
