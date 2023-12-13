public ActionResult Demo()
{
    List<Step> iconWithLabel = new List<Step>();
    iconWithLabel.Add(new Step { Label = "Cart", IconCss = "sf-icon-cart" });
    iconWithLabel.Add(new Step { Label = "Address", IconCss = "sf-icon-user" });
    iconWithLabel.Add(new Step { Label = "Delivery", IconCss = "sf-icon-transport" });
    iconWithLabel.Add(new Step { Label = "Payment", IconCss = "sf-icon-payment", Optional = true });
    iconWithLabel.Add(new Step { Label = "Ordered", IconCss = "sf-icon-success" });
    ViewBag.datasource = iconWithLabel;
    
    return View();
}