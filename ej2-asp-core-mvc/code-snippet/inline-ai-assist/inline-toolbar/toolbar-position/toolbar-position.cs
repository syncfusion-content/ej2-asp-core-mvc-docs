public List<InlineToolbarItemModel> Items { get; set; } = new List<InlineToolbarItemModel>();

public ActionResult InlineToolbarSettings()
{
    Items.Add(new InlineToolbarItemModel { text = "Welcome User!", align= "Right" });
    Items.Add(new InlineToolbarItemModel { iconCss = "e-icons e-assistview-icon", align = "Right" });
    ViewBag.Items = Items;
    return View();
}

public class InlineToolbarItemModel
{
    public string type { get; set; }
    public string iconCss { get; set; }
    public string align { get; set; }
    public string cssClass { get; set; }
    public string tooltip { get; set; }
    public string text { get; set; }
    public bool visible { get; set; } = true;
    public bool disabled { get; set; }
}