public ActionResult Demo()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    items.Add(new SpeedDialItem
    {
        Text="Cut"
    });
    items.Add(new SpeedDialItem
    {
        Text="Copy"
    });
    items.Add(new SpeedDialItem
    {
        Text="Paste"
    });
    ViewBag.datasource = items;
    
    return View();
}