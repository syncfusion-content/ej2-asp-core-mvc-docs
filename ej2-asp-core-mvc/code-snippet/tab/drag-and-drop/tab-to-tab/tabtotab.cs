public ActionResult Index()
{
    ViewBag.headerTextOne = new TabHeader { Text = "India" };
    ViewBag.headerTextTwo = new TabHeader { Text = "Australia" };
    ViewBag.headerTextThree = new TabHeader { Text = "USA" };
    ViewBag.headerTextFour = new TabHeader { Text = "France" };
    ViewBag.headerTextFive = new TabHeader { Text = "HTML" };
    ViewBag.headerTextSix = new TabHeader { Text = "C Sharp(C#)" };
    ViewBag.headerTextSeven = new TabHeader { Text = "Java" };
    ViewBag.headerTextEight = new TabHeader { Text = "VB.Net" };
    return View();
}