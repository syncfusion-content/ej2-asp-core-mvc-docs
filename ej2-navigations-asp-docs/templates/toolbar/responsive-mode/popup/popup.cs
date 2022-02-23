public ActionResult Index()
{
    List<ToolbarItem> popItems = new List<ToolbarItem>();
    popItems.Add(new ToolbarItem { PrefixIcon = "e-cut-icon", Text = "Cut", Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-copy-icon", Text = "Copy", Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-paste-icon", Text = "Paste", Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { Type = ItemType.Separator });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-bold-icon", Text = "Bold", Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-underline-icon", Text = "Underline", Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-italic-icon", Text = "Italic", Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { Type = ItemType.Separator });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-ascending-icon", Text = "A-Z Sort", Overflow = OverflowOption.Show });
    popItems.Add(new ToolbarItem { PrefixIcon = "e-descending-icon", Text = "Z-A Sort", Overflow = OverflowOption.Show });
    ViewBag.popItems = popItems;
    return View();
}