using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EJ2CoreSampleBrowser.Controllers.MaskedTextbox
{
    public class MaskValue
    {
        [Required]
        public string value { get; set; }

    }
    public partial class MaskedTextboxController : Controller
    {

        public ActionResult DefaultFunctionalities()
        {
            MaskValue val = new MaskValue();
            val.value = "10";
            return View(val);
        }
        [HttpPost]
        public ActionResult DefaultFunctionalities(MaskValue model)
        {
            MaskValue val = new MaskValue();
            val.value = model.value;
            return View(val);
        }
    }
}