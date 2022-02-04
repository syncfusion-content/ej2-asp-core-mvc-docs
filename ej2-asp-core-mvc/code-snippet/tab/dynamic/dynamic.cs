public ActionResult Index()
{
    ViewBag.headerTextOne = new TabHeader { Text = "USA" };
    ViewBag.headerTextTwo = new TabHeader { IconCss = "e-add-icon" };
    return View();
}