public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
public ActionResult CustomFooter()
{
    Items.Add(new ToolbarItemModel {iconCss = "e-icons e-assistview-icon", align = "Left"});
    ViewBag.Items = Items;
    return View();
}

public class ToolbarItemModel
{
    public string iconCss { get; set; }
    public string align { get; set; }
}