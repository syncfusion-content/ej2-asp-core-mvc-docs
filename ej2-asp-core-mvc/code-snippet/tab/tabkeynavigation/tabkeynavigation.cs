public ActionResult Index()
{
    ViewBag.headerText0 = new TabHeader { Text = "HTML" };
    ViewBag.headerText1 = new TabHeader { Text = "C Sharp(C#)" };
    ViewBag.headerText2 = new TabHeader { Text = "Java" };
    ViewBag.headerText3 = new TabHeader { Text = "VB.Net" };
    ViewBag.headerText4 = new TabHeader { Text = "Xamarin" };
    ViewBag.headerText5 = new TabHeader { Text = "ASP.NET" };
    ViewBag.headerText6 = new TabHeader { Text = "ASP.NET MVC" };
    ViewBag.headerText7 = new TabHeader { Text = "JavaScript" };
    return View();
}