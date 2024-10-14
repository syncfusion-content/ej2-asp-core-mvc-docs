public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
public ActionResult Tooltip()
{
    Items.Add(new ToolbarItemModel { type = "Button", iconCss = "e-icons e-refresh", align = "Right", tooltip = "Refresh" });
    ViewBag.Items = Items;
    return View();
}

public class ToolbarItemModel
{
    public string type { get; set; }
    public string iconCss { get; set; }
    public string align { get; set; }
    public string tooltip { get; set; }
}