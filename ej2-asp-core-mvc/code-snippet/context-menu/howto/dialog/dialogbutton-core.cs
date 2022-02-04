public ActionResult DialogButton()
{
    ViewBag.DialogButtons = new
            {
                isPrimary = true,
                cssClass = "e-flat",
                content = "Submit",
                click = "dlgButtonClick"
            };
    return View();
}