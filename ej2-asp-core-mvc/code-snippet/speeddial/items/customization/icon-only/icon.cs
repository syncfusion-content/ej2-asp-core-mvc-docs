public ActionResult Icon()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    items.Add(new SpeedDialItem
    {
        Title="Cut",
        IconCss="e-icons e-cut"
    });
    items.Add(new SpeedDialItem
    {
        Title="Copy",
        IconCss="e-icons e-copy"
    });
    items.Add(new SpeedDialItem
    {
        Title="Paste",
        IconCss="e-icons e-paste"   
    });

    ViewBag.datasource = items;
    return View();
}
