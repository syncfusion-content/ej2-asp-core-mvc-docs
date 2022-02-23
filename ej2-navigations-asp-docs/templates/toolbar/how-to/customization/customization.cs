public ActionResult Index()
{
    List<ToolbarItem> items = new List<ToolbarItem>();
    items.Add(new ToolbarItem { Text = "Bold", Type = ItemType.Button , HtmlAttributes = new HtmlAttributes { Class = "custom_bold", Id = "itemId" } });
    items.Add(new ToolbarItem { Text = "Italic", HtmlAttributes = new HtmlAttributes { Class = "custom_italic"} });
    items.Add(new ToolbarItem { Text = "Underline", HtmlAttributes = new HtmlAttributes { Class = "custom_underline" } });
    items.Add(new ToolbarItem { Type = ItemType.Separator });
    items.Add(new ToolbarItem { Text = "Uppercase", CssClass = "e-txt-casing" });
    ViewBag.Items = items;
    return View();
}

public class HtmlAttributes
{
    public string Class { get; set; }
    public string Id { get; set; }
}