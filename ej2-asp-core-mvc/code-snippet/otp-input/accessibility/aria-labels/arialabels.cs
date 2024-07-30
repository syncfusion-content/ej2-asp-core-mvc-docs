public ActionResult Arialabels()
{
    string[] ariaLabels = {"First digit", "Second digit", "Third digit", "Fourth digit"};
    ViewBag.ariaLabels = ariaLabels;
    return View();
}