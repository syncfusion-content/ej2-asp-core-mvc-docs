public IActionResult Index()
{
    ViewBag.ComplexDataSource = ComplexData.GetAllRecords();
    return View();
} 