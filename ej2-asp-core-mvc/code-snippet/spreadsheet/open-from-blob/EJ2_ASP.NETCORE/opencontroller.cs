public IActionResult Open(IFormCollection openRequest)
{
    OpenRequest open = new OpenRequest();
    open.File = openRequest.Files[0];
    return Content(Workbook.Open(open));
}

public IActionResult Save(SaveSettings saveSettings)
{
    return Workbook.Save(saveSettings);
}