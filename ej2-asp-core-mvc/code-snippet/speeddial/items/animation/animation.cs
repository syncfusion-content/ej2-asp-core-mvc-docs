public ActionResult Animation()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    items.Add(new SpeedDialItem
    {
        Text = "Cut",
        IconCss="e-icons e-cut"
    });
    items.Add(new SpeedDialItem
    {
        Text = "Copy",
        IconCss="e-icons e-copy"
    });
    items.Add(new SpeedDialItem
    {
        Text = "Paste",
        IconCss="e-icons e-paste"
    });

    ViewBag.datasource = items;
    return View();
}
