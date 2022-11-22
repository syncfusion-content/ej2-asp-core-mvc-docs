public ActionResult Default()
{
    List<object> items = new List<object>();
    items.Add(new
    {
        text = "Png"
    });
    items.Add(new
    {
        text = "Jpeg"
    });
    items.Add(new
    {
        text = "Svg"
    });
    ViewBag.datasource = items;
    return View();
}