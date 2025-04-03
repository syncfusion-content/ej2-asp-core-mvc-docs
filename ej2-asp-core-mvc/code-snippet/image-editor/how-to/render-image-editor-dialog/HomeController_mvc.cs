using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Popups;
using Syncfusion.EJ2.ImageEditor;

namespace EJ2MVCSampleBrowser.Controllers.ImageEditor
{
    public partial class ImageEditorController : Controller
    {
        public ActionResult ProfilePicture()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new DefaultButtonModel() { content = "Close Dialog", isPrimary = true } });
            ViewBag.DefaultButtons = buttons;
            return View();
        }
    }
    public class DefaultButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}