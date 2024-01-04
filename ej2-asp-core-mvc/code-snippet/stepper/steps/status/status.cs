public ActionResult Demo()
{
    List<Step> iconLabel = new List<Step>();
    iconLabel.Add(new Step { Label = "Cart", IconCss = "sf-icon-cart" });
    iconLabel.Add(new Step { Label = "Payment", IconCss = "sf-icon-payment"});
    iconLabel.Add(new Step { Label = "Ordered", IconCss = "sf-icon-success" });
    
    ViewBag.datasource = iconLabel;
    
    return View();
}