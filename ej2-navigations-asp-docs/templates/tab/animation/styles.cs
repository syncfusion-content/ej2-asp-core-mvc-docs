public ActionResult Index()
{
    ViewBag.headerText0 = new TabHeader { Text = "Twitter" };
    ViewBag.headerText1 = new TabHeader { Text = "Facebook" };
    ViewBag.headerText2 = new TabHeader { Text = "WhatsApp" };
    ViewBag.animationData = new string[] { "SlideLeftIn", "SlideRightIn", "FadeIn", "FadeOut", "FadeZoomIn", "FadeZoomOut", "ZoomIn", "ZoomOut", "None" };
    return View();
}