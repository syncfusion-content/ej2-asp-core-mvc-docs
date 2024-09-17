using Syncfusion.EJ2.Navigations;

public List<ToolbarItem> Items = new List<ToolbarItem>();
public ActionResult Text()
{
    Items.Add(new ToolbarItem { Text = "Your personalized assistant for smarter prompts and responses.", Align = ItemAlign.Center });
    ViewBag.Items = Items;
    return View();
}