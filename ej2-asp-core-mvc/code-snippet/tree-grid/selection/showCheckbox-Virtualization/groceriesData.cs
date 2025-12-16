public IActionResult Index()
{
    var treeData = GroceryDataGenerator.GenerateGroceriesData();
    ViewData["datasource"] = treeData;
    return View();
}