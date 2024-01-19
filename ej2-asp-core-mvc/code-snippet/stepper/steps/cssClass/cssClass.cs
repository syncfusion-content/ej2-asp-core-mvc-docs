public ActionResult Demo()
{
    List<Step> iconLabel = new List<Step>();
    iconLabel.Add(new Step { Label = "Cart" IconCss = "sf-icon-cart" });
    iconLabel.Add(new Step { Label = "Delivery Address"  IconCss = "sf-icon-transport" });
    iconLabel.Add(new Step { Label = "Payment" IconCss = "sf-icon-payment", CssClass = "custom-step", Optional = true});
    iconLabel.Add(new Step { Label = "Confirmation" IconCss = "sf-icon-success" });
    ViewBag.IconLabel = iconLabel;
    
    return View();
}