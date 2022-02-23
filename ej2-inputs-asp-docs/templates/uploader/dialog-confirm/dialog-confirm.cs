using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.TextBoxes
{
    public partial class UploaderController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            List<DialogDialogButton> button = new List<DialogDialogButton>() { };
            button.Add(new DialogDialogButton() { Click = "confirmBtnClick", ButtonModel = new confirmButtonModel() { content = "Cancel", isPrimary = true } });
            button.Add(new DialogDialogButton() { Click = "confirmBtnClick", ButtonModel = new confirmButtonModel() { content = "OK"} });
            ViewBag.confirmbutton = button;
            return View();
            
        }
    }
    
    public class confirmButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}
