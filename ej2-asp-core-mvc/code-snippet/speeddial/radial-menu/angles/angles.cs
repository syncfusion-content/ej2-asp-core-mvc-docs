public ActionResult Angles()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    items.Add(new SpeedDialItem
    {
        IconCss = "e-icons e-cut"
    });
    items.Add(new SpeedDialItem
    {
        IconCss = "e-icons e-copy"
    });
    items.Add(new SpeedDialItem
    {
        IconCss = "e-icons e-paste"
    });
    items.Add(new SpeedDialItem
    {
        IconCss = "e-icons e-edit"
    });
    items.Add(new SpeedDialItem
    {
        IconCss = "e-icons e-save"
    });

    ViewBag.datasource = items;
    return View();
}
