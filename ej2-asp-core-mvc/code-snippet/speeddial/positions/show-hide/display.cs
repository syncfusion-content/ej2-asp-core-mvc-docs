public ActionResult Display()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    items.Add(new SpeedDialItem
    {
        IconCss="e-icons e-cut"
    });
    items.Add(new SpeedDialItem
    {
        IconCss="e-icons e-copy"
    });
    items.Add(new SpeedDialItem
    {
        IconCss="e-icons e-paste"   
    });

    ViewBag.datasource = items;
    return View();
}
