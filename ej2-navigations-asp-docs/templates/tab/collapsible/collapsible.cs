public ActionResult Index()
{
    ViewBag.headerTextOne = new TabHeader { Text = "Twitter" };
    ViewBag.headerTextTwo = new TabHeader { Text = "Facebook" };
    ViewBag.headerTextThree = new TabHeader { Text = "WhatsApp" };
    return View();
}