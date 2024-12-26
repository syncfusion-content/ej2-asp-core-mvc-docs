public ActionResult Open(OpenRequest openRequest)
{
    return Content(Workbook.Open(openRequest));
}

public void Save(SaveSettings saveSettings)
{
    Workbook.Save(saveSettings);
}