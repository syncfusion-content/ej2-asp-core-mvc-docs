using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class TimePicker
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime? value { get; set; }

    }
    public class HomeController : Controller
    {
        TimePicker TimePickerValue = new TimePicker();
        public ActionResult Index()
        {
            TimePickerValue.value = new DateTime(2020, 03, 03, 10, 00, 00);
            return View(TimePickerValue);
        }
        [HttpPost]
        public ActionResult Index(TimePicker model)
        {
            //posted value is obtained from the model
            TimePickerValue.value = model.value;
            return View(TimePickerValue);
        }
    }
}
