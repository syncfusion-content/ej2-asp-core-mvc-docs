public IActionResult Index()
{
    var ComplexData = ComplexData.GetAllRecords();
    ViewBag.DataSource = ComplexData;
    return View();
} 