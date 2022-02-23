public ActionResult Index()
{
    List<ToolbarItem> popItems = new List<ToolbarItem>();
    popItems.Add(new ToolbarItem { PrefixIcon = "e-cut-icon", Text = "Cut", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-copy-icon", Text = "Copy", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-paste-icon", Text = "Paste", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { Type = ItemType.Separator });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-bold-icon", Text = "Bold", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-underline-icon", Text = "Underline", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-italic-icon", Text = "Italic", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-color-icon", Text = "Color-Picker", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { Type = ItemType.Separator });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-ascending-icon", Text = "A-Z Sort", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-descending-icon", Text = "Z-A Sort", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-clear-icon", Text = "Clear", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
    ViewBag.popItems = popItems;
    return View();
}