public ActionResult Open(OpenRequest openRequest) {
    string result = Workbook.Open(openRequest);
    return Content(result);
}

public void Save(SaveSettings saveSettings)
{
    Workbook.Save(saveSettings);
}