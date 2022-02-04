using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class DateTimePicker
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime? value { get; set; }

    }
    public class HomeController : Controller
    {
        DateTimePicker DateTimePickerValue = new DateTimePicker();
        public ActionResult Index()
        {
            DateTimePickerValue.value =  new DateTime(2020, 03, 03, 10, 00, 00);
            return View(DateTimePickerValue);
        }
        [HttpPost]
        public ActionResult Index(DateTimePicker model)
        {
            //posted value is obtained from the model
            DateTimePickerValue.value = model.value;
            return View(DateTimePickerValue);
        }
    }
}
