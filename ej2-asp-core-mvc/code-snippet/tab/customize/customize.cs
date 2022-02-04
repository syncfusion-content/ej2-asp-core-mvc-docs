public ActionResult Index()
{
    ViewBag.headerTextOne = new TabHeader { Text = "<div><div class='e-image e-andrew'></div><div class='e-title fade-in'>Andrew</div></div>" };
    ViewBag.headerTextTwo = new TabHeader { Text = "<div><div class='e-image e-margaret'></div><div class='e-title fade-in'>Margaret</div></div>" };
    ViewBag.headerTextThree = new TabHeader { Text = "<div><div class='e-image e-janet'></div><div class='e-title fade-in'>Janet</div></div>" };
    return View();
}