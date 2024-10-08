public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
public ActionResult ItemClicked()
{
    Items.Add(new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" });
    ViewBag.Items = Items;
    return View();
}

public class ToolbarItemModel
{
    public string iconCss { get; set; }
    public string align { get; set; }
}