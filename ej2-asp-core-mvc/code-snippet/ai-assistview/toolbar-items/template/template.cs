using Syncfusion.EJ2.Navigations;

public List<ToolbarItem> Items = new List<ToolbarItem>();
public ActionResult Template()
{
    Items.Add(new ToolbarItem { Type = ItemType.Input, Template = "<div id=\"ddMenu\"></div>", Align = ItemAlign.Center });
    ViewBag.Items = Items;
    return View();
}