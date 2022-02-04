public ActionResult DialogButton()
{
    List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
    buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new ButtonModel() { content = "SUBMIT", isPrimary = true } });
    ViewBag.DialogButtons = buttons;
    return View();
}