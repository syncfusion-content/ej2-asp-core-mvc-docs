public ActionResult Demo()
{
    List<Step> labelOnly = new List<Step>();
    labelOnly.Add(new Step { Label = "Cart" });
    labelOnly.Add(new Step { Label = "Delivery Address" });
    labelOnly.Add(new Step { Label = "Payment" });
    labelOnly.Add(new Step { Label = "Confirmation" });
    
    ViewBag.datasource = labelOnly;
    
    return View();
}