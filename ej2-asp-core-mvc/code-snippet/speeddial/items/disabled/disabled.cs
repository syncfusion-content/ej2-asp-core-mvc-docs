public ActionResult Icon()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    items.Add(new SpeedDialItem
    {
        Text="Cut",
        Disabled=true
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
