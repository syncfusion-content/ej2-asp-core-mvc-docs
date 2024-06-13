public ActionResult Htmlattributes()
{
    Dictionary<string, object> htmlAttributes = new Dictionary<string, object>()
    {
        { "title", "One-Time Password" }
    };
    ViewBag.htmlAttributes = htmlAttributes;
    return View();
}