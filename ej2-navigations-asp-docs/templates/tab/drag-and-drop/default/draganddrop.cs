public ActionResult Index()
{
    ViewBag.headerTextOne = new TabHeader { Text = "India" };
    ViewBag.headerTextTwo = new TabHeader { Text = "Australia" };
    ViewBag.headerTextThree = new TabHeader { Text = "USA" };
    ViewBag.headerTextFour = new TabHeader { Text = "France" };
    return View();
}