public IActionResult Index()
{
    var Order = OrderDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
} 

public ActionResult Editpartial(DialogTemplateModel value)
{
    var order = OrdersDetails.GetAllRecords();
    ViewBag.datasource = order;
    return PartialView("Editpartial", value);
}

public ActionResult AddPartial()
{
    var order = OrdersDetails.GetAllRecords();
    ViewBag.datasource = order;
    return PartialView("Addpartial");
}
