public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
public ActionResult CustomPrompt()
{
    Items.Add(new ToolbarItemModel { iconCss = "e-icons e-edit" });
    ViewBag.Items = Items;
    return View();
}

public class ToolbarItemModel
{
    public string iconCss { get; set; }
}