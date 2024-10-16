public IActionResult Index()
{
    ViewBag.TaskDataSource = TaskDetails.GetAllRecords();
    return View();
} 