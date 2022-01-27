public IActionResult Index()
{
    var Category = CategoryDetails.GetAllRecords();
    ViewBag.DataSource = Category;
    return View();
} 