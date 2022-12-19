using Syncfusion.EJ2.Popups;
using System.Web.Mvc;
using System.Collections.Generic;
public class HomeController : Controller
{
     public ActionResult Index()
    {
        List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
        buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new DefaultButtonModel() { content = "Okay", isPrimary = true } });
        ViewBag.DefaultButtons = buttons;
        return View();
    }
    public class DefaultButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}