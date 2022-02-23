public IActionResult Index()
{
    var Catogory = CatogoryDetails.GetAllRecords();
    ViewBag.DataSource = Catogory;
    return View();
} 