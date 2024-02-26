public ActionResult Demo()
{
    List<Step> iconText = new List<Step>();
    iconText.Add(new Step { Text = "Cart", IconCss = "sf-icon-cart" });
    iconText.Add(new Step { Text = "Delivery Address", IconCss = "sf-icon-transport" });
    iconText.Add(new Step { Text = "Payment", IconCss = "sf-icon-payment" });
    iconText.Add(new Step { Text = "Confirmation", IconCss = "sf-icon-success" });
    
    ViewBag.IconText = iconText;
    
    return View();
}