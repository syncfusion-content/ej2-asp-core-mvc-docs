public ActionResult Mode()
{
    List<SpeedDialItem> items = new List<SpeedDialItem>();
    List<SpeedDialItem> items1 = new List<SpeedDialItem>();
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
    items1.Add(new SpeedDialItem
    {
        IconCss="e-icons e-cut",
        Text="Cut"
    });
    items1.Add(new SpeedDialItem
    {
        IconCss="e-icons e-copy",
        Text="Copy"
    });
    items1.Add(new SpeedDialItem
    {
        IconCss="e-icons e-paste",
        Text="Paste"
    });
    ViewBag.datasource = items;
    ViewBag.datasourceLabel = items1;
    
    return View();
}