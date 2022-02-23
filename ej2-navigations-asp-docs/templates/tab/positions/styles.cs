public ActionResult Index()
{
    ViewBag.headerText0 = new TabHeader { Text = "Twitter", IconCss= "e-twitter" };
    ViewBag.headerText1 = new TabHeader { Text = "Facebook", IconCss = "e-facebook" };
    ViewBag.headerText2 = new TabHeader { Text = "WhatsApp", IconCss = "e-whatsapp" };
    ViewBag.positionData = new string[] { "left", "right", "top", "bottom" };
    return View();
}