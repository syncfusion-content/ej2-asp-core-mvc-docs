public ActionResult DialogButton()
{
    List<object> buttons = new List<object>() { };
    buttons.Add(new
    {
        isPrimary = true,
        cssClass = "e-flat",
        content = "ok",
        click = "okBtnClick"
    });
    buttons.Add(new
    {
        isPrimary = true,
        cssClass = "e-flat",
        content = "cancel",
        click = "cancelBtnClick"
    });
    ViewBag.DialogButtons = buttons;
    return View();
}