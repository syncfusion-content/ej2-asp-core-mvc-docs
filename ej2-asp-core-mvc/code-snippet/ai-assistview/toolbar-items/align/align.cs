public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();

public ActionResult Align()
{
    Items.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
    ViewBag.Items = Items;
    return View();
}

public class ToolbarItemModel
{
    public string align { get; set; }

    public string iconCss { get; set; }
}