using Syncfusion.EJ2.Navigations;

public List<ToolbarItem> Items = new List<ToolbarItem>();
public ActionResult Template()
{
    Items.Add(new ToolbarItem { Type = ItemType.Input, Template = "Your personalized assistant for smarter prompts and responses.", Align = ItemAlign.Center });
    ViewBag.Items = Items;
    return View();
}