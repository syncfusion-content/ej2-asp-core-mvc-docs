public IActionResult Index()
{
    var ComplexData = ComplexData.GetAllRecords();
    ViewBag.data = ComplexData;
    return View();
} 