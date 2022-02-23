using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class NumericValue
    {
        [Required(ErrorMessage = "Value is required")]
        public int value { get; set; }
    }
    public partial class NumericTextboxController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            NumericValue num = new NumericValue();
            num.value = 10;
            Syncfusion.EJ2.Inputs.NumericTextBox num1 = new Syncfusion.EJ2.Inputs.NumericTextBox();
            num1.Max = 100;
            ViewData["Numeric"] = num1;
            return View(num);
        }
        [HttpPost]
        public ActionResult DefaultFunctionalities(NumericValue model)
        {

            NumericValue num = new NumericValue();
            num.value = 10;
            Syncfusion.EJ2.Inputs.NumericTextBox num1 = new Syncfusion.EJ2.Inputs.NumericTextBox();
            num1.Min = 2;
            ViewData["Numeric"] = num1;
            return View(model);
        }
    }

}