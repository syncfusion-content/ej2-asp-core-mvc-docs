public ActionResult Index()
{
    ViewBag.headerText0 = new TabHeader { Text = "Twitter" };
    ViewBag.headerText1 = new TabHeader { Text = "Facebook" };
    ViewBag.headerText2 = new TabHeader { Text = "WhatsApp" };
    return View();
}