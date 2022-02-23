public ActionResult Index()
{
    ViewBag.headerText0 = new TabHeader { Text = "Twitter" };
    ViewBag.headerText1 = new TabHeader { Text = "Facebook" };
    ViewBag.headerText2 = new TabHeader { Text = "Whatsapp" };

    ViewBag.stylesData = new string[] { "Default", "Fill", "Background", "Accent" };
    return View();
}