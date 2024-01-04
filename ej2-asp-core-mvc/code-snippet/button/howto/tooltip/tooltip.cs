public ActionResult tooltip()
{   
    Dictionary<string, object> Attributes = new Dictionary<string, object>()
    {
        { "title", "Primary Button" }
    };
    ViewBag.Attributes = Attributes;
    return View();
}