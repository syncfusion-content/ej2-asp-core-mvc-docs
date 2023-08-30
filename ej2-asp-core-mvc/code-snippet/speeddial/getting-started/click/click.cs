public ActionResult ItemClick()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    items.Add(new SpeedDialItem
    {
        IconCss="e-icons e-cut",
        Text="Cut"
    });
    items.Add(new SpeedDialItem
    {
        IconCss="e-icons e-copy",
        Text="Copy"
    });
    items.Add(new SpeedDialItem
    {
        IconCss="e-icons e-paste",
        Text="Paste"
    });
    ViewBag.datasource = items;
    
    return View();
}