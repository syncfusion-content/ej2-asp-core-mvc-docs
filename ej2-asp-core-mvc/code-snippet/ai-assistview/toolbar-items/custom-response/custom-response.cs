public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
public ActionResult CustomResponse()
{
    Items.Add(new ToolbarItemModel { iconCss = "e-icons e-download" });
    Items.Add(new ToolbarItemModel { iconCss = "e-icons e-refresh" });
    Items.Add(new ToolbarItemModel { iconCss = "e-icons e-assist-like" });
    Items.Add(new ToolbarItemModel { iconCss = "e-icons e-assist-dislike" });
    ViewBag.Items = Items;
    return View();
}

public class ToolbarItemModel
{
    public string iconCss { get; set; }
}