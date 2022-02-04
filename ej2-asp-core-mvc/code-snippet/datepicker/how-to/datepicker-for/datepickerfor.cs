using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class DatePicker
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime? value { get; set; }
    }
    public class HomeController : Controller
    {
        DatePicker DatePickerValue = new DatePicker();
        public ActionResult Index()
        {
            DatePickerValue.value =  new DateTime(2020, 03, 03);
            return View(DatePickerValue);
        }
        [HttpPost]
        public ActionResult Index(DatePicker model)
        {
            //posted value is obtained from the model
            DatePickerValue.value = model.value;
            return View(DatePickerValue);
        }
    }
}
