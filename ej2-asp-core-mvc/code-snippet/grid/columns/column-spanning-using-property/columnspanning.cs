public IActionResult Index()
{
    ViewBag.DataSource = shiftPlanData.GetAllRecords()
    return View();
} 