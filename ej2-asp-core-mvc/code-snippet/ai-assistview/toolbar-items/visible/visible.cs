using Syncfusion.EJ2.Navigations;

public List<ToolbarItem> Items = new List<ToolbarItem>();
public ActionResult Visible()
{
    Items.Add(new ToolbarItem { Visible = false, Align = ItemAlign.Right, CssClass = "e-icons e-refresh" });
    ViewBag.Items = Items;
    return View();
}
