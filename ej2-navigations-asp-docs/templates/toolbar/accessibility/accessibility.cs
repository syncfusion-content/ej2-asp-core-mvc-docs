public ActionResult Index()
{
    List<ToolbarItem> popItems = new List<ToolbarItem>();
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-cut-icon", Text = "Cut", ShowTextOn = DisplayMode.Overflow });
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-copy-icon", Text = "Copy", ShowTextOn = DisplayMode.Overflow });
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-cut-icon", Text = "Paste", ShowTextOn = DisplayMode.Overflow });
    popItems.Add(new ToolbarItem { Type = ItemType.Separator });
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-bold-icon", Text = "Bold", ShowTextOn = DisplayMode.Overflow });
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-underline-icon", Text = "Underline", ShowTextOn = DisplayMode.Overflow });
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-italic-icon", Text = "Italic", ShowTextOn = DisplayMode.Overflow });
    popItems.Add(new ToolbarItem { Type = ItemType.Separator });
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-ascending-icon", Text = "A-Z Sort", ShowTextOn = DisplayMode.Overflow });
    popItems.Add(new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-descending-icon", Text = "Z-A Sort", ShowTextOn = DisplayMode.Overflow });
    ViewBag.Items = popItems;
    return View();
}