using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.SplitButtons;
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

        public ActionResult SplitButton()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Help"
            });
            items.Add(new
            {
                text = "About"
            });
            items.Add(new
            {
                text = "Update..."
            });
        
            ViewBag.items = items;
    
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "okBtnClick", ButtonModel = new ButtonModel() { content = "OK", isPrimary = true } });
            buttons.Add(new DialogDialogButton() { Click = "cancelBtnClick", ButtonModel = new ButtonModel() { content = "Cancel", isPrimary = true } });
            ViewBag.button = buttons;
            return View();
        }
    }
}