public ActionResult Demo()
{
    List<Step> iconOnly = new List<Step>();
    iconOnly.Add(new Step { IconCss = "sf-icon-cart" });
    iconOnly.Add(new Step { IconCss = "sf-icon-transport" });
    iconOnly.Add(new Step { IconCss = "sf-icon-payment"});
    iconOnly.Add(new Step { IconCss = "sf-icon-success" });
    ViewBag.IconOnly = iconOnly;
    
    return View();
}