public IActionResult Index()
{
    var Records = InventorDetails.GetAllRecords();
    ViewBag.DataSource = Records;
    return View();
} 