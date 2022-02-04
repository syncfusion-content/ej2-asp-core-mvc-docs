using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class DateRangePicker
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime?[] value { get; set; }
    }
    public class HomeController : Controller
    {
        DateRangePicker DateRangeValue = new DateRangePicker();
        public ActionResult Index()
        {
            DateRangeValue.value = new DateTime?[] { new DateTime(2020, 03, 03), new DateTime(2021, 09, 03) };
            return View(DateRangeValue);
        }
        [HttpPost]
        public ActionResult Index(DateRangePicker model)
        {
            //posted value is obtained from the model
            DateRangeValue.value = model.value;
            var startDate = model.value[0];
            var endDate = model.value[1];
            return View(DateRangeValue);
        }
    }
}
