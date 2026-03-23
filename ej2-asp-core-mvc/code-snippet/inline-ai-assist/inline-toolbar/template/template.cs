public List<InlineToolbarItemModel> Items { get; set; } = new List<InlineToolbarItemModel>();

public ActionResult InlineToolbarSettings()
{
    Items.Add(new InlineToolbarItemModel { type = "Input", template = "<div id=\"ddMenu\"></div>", align = "Right" });
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