using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace EJ2MVCSampleBrowser.Controllers
{
    public class MaskValue
    {
        [Required(ErrorMessage = "MaskedValue is required")]
        public string value { get; set; }
    }
    public partial class MaskedTextBoxController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            MaskValue newmask = new MaskValue();
            Syncfusion.EJ2.Inputs.MaskedTextBox mask1 = new Syncfusion.EJ2.Inputs.MaskedTextBox();
            ViewData["Mask"] = mask1;
            return View(newmask);
        }
        [HttpPost]
        public ActionResult DefaultFunctionalities(MaskValue model)
        {

            MaskValue newmask = new MaskValue();
            Syncfusion.EJ2.Inputs.MaskedTextBox mask1 = new Syncfusion.EJ2.Inputs.MaskedTextBox();
            mask1.ShowClearButton = true;
            ViewData["Mask"] = mask1;
            return View(model);
        }
    }

}