public IActionResult Index()
{
    ViewBag.DataSource =OrderDetails.GetAllRecords();
    return View();
} 

public ActionResult Editpartial(DialogTemplateModel value)
{
    ViewBag.datasource = OrdersDetails.GetAllRecords();
    return PartialView("EditPartial", value);
}

public ActionResult AddPartial()
{
    ViewBag.datasource = OrdersDetails.GetAllRecords();
    return PartialView("AddPartial");
}
