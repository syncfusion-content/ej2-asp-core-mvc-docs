using Syncfusion.EJ2.Navigations;

public List<ToolbarItem> Items = new List<ToolbarItem>();
public ActionResult Text()
{
    Items.Add(new ToolbarItem { Text = "Welcome User !", Align = ItemAlign.Right });
    ViewBag.Items = Items;
    return View();
}