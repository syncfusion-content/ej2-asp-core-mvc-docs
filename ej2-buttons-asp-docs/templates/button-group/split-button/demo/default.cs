public ActionResult Index()
{
    // Define the array of JSON
    List<object> items = new List<object>();
    items.Add(new
    {
        text = "Paste"
    });
    items.Add(new
    {
        text = "Paste Text"
    });
    items.Add(new
    {
        text = "Paste Special"
    });
    ViewBag.items = items;
    return View();
}