public ActionResult Index()
{
    List<object> productDropDownButtonItems = new List<object>();
    productDropDownButtonItems.Add(new
    {
        text = "Developer",
    });
    productDropDownButtonItems.Add(new
    {
        text = "Analytics",
    });
    productDropDownButtonItems.Add(new
    {
        text = "Reporting",
    });
    productDropDownButtonItems.Add(new
    {
        text = "E-Signature",
    });
    productDropDownButtonItems.Add(new
    {
        text = "Help-Desk",
    });
    ViewBag.ProductDropDownButtonItems = productDropDownButtonItems;
    return View();
}