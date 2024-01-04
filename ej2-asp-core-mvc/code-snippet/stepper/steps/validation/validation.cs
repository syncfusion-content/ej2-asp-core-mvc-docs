public ActionResult Demo()
{
    List<Step> iconSteps = new List<Step>();
    iconSteps.Add(new Step { IconCss = "sf-icon-cart", IsValid = true });
    iconSteps.Add(new Step { IconCss = "sf-icon-transport" });
    iconSteps.Add(new Step { IconCss = "sf-icon-payment", IsValid = false});
    iconSteps.Add(new Step { IconCss = "sf-icon-success" });

    List<Step> labelSteps = new List<Step>();
    labelSteps.Add(new Step { Label = "Cart", IsValid = true  });
    labelSteps.Add(new Step { Label = "Delivery Address" });
    labelSteps.Add(new Step { Label = "Payment", IsValid = false  });
    labelSteps.Add(new Step { Label = "Confirmation" });

    ViewBag.IconSteps = iconSteps;
    ViewBag.LabelSteps = labelSteps;
    
    return View();
}