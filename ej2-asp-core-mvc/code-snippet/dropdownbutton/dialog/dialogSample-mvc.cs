using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Buttons;
using Syncfusion.EJ2.Popups;
namespace EJ2CoreSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public class ButtonModel
        {
            public string content { get; set; }
            public string cssClass { get; set; }
            public bool isPrimary { get; set; }
            public string Click { get; set; }

        }

        public ActionResult DropDownButton()
        {

            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Archive"
            });
            items.Add(new
            {
                text = "Inbox"
            });
            items.Add(new
            {
                text = "HR Portal"
            });
            items.Add(new
            {
                separator = true
            });
            items.Add(new
            {
                text = "Other Folder..."
            });
            items.Add(new
            {
                text = "Copy to Folder"
            });
            ViewBag.button = new
            {
                content="OK", cssClass="e-flat", isPrimary = true
            };
            ViewBag.items = items;
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "btnClick", ButtonModel = new ButtonModel() { content = "OK", isPrimary = true, cssClass = "e-flat" } });
            ViewBag.button = buttons;
            return View();
        }
    }
}
