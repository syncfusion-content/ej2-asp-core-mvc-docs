public ActionResult Index()
{
    Dictionary<string, object> htmlAttribute = new Dictionary<string, object>()
    {   {"aria-label", "appbar" } };
    ViewBag.HtmlAttribute = htmlAttribute;
    return View();
}