public ActionResult Demo()
{
    List<Step> textOnly = new List<Step>();
    textOnly.Add(new Step { Text = "A" });
    textOnly.Add(new Step { Text = "B" });
    textOnly.Add(new Step { Text = "C" });
    textOnly.Add(new Step { Text = "D" });

    List<Step> labelOnly = new List<Step>();
    labelOnly.Add(new Step { Label = "Cart" });
    labelOnly.Add(new Step { Label = "Delivery Address" });
    labelOnly.Add(new Step { Label = "Payment" });
    labelOnly.Add(new Step { Label = "Confirmation" });
    
    ViewBag.labelOnly = labelOnly;
    ViewBag.textOnly = textOnly;
    
    return View();
}