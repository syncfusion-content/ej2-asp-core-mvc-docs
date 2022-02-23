// ToolBar
public ActionResult ToolBar()
{
    List<ToolbarItem> items = new List<ToolbarItem>()
            {
                new ToolbarItem { Template ="<ul id='menu'></ul>" },
                new ToolbarItem { PrefixIcon ="em-icons e-shopping-cart", Align=Syncfusion.EJ2.Navigations.ItemAlign.Right }
            };

    ViewBag.items = items;
    return View();
}