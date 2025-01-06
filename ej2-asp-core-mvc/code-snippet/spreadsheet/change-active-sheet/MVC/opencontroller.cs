public ActionResult Open(OpenRequest openRequest)
{
    return Content(Workbook.Open(openRequest));
}