public ActionResult Index()
{
    // Define the array of JSON
    List<object> items = new List<object>();
    items.Add(new
    {
        text = "Learn SQL"
    });
    items.Add(new
    {
        text = "Learn PHP"
    });
    items.Add(new
    {
        text = "Learn Bootstrap"
    });
    ViewBag.items = items;
    return View();
}