public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();

public ActionResult CssClass()
{
    Items.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-user", cssClass = "e-custom", type = "Button" });
    ViewBag.Items = Items;
    return View();
}

public class ToolbarItemModel
{
    public string align { get; set; }
    public string iconCss { get; set; }
    public string type { get; set; }
    public string cssClass { get; set; }
}