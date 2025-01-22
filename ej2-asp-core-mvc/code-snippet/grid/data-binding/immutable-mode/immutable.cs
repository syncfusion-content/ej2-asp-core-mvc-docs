public ActionResult Index()
{
    ViewBag.DataSource = OrderDetails.GetAllRecords();
    return View();
} 