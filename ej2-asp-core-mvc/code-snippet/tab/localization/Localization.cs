public ActionResult Index()
{
    ViewBag.headerText0 = new TabHeader { Text = "HTML" };
    ViewBag.headerText1 = new TabHeader { Text = "C Sharp(C#)" };
    ViewBag.headerText2 = new TabHeader { Text = "Java" };
    return View();
}