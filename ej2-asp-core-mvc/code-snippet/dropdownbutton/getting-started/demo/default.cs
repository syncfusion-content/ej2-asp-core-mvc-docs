public ActionResult Index()
{
    List<object> items = new List<object>();
    items.Add(new
    {
        text = "Cut"
    });
    items.Add(new
    {
        text = "Copy"
    });
    items.Add(new
    {
        text = "Paste"
    });
    ViewBag.items = items;
    return View();
}