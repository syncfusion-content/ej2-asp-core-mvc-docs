using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class NumericValue
    {
        [Required]
        public int value { get; set; }

    }
    public partial class NumericTextBoxController : Controller
    {
        public IActionResult DefaultFunctionalities()
        {
            NumericValue val = new NumericValue();
            val.value = 10;
            return View(val);
        }
        [HttpPost]
        public IActionResult DefaultFunctionalities(NumericValue model)
        {
            NumericValue val = new NumericValue();
            val.value = model.value;
            return View(val);
        }
    }
}
