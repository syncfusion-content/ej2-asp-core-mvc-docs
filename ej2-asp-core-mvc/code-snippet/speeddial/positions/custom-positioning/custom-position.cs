public ActionResult CustomPosition()
{
    items.Add(new SpeedDialItem
    {
        Text = "cut"
    });
    items.Add(new SpeedDialItem
    {
        Text = "copy"
    });
    items.Add(new SpeedDialItem
    {
        Text = "paste"
    });

    ViewBag.datasource = items;
    return View();
}
