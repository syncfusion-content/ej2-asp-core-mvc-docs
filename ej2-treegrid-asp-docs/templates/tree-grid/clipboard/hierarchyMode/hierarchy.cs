public IActionResult Index()
{
    var treeData = TreeGridItems.GetTreeData();
    ViewBag.datasource = treeData;           
    List<Object> dropData = new List<object>() {
        new { id = "Parent", mode = "Parent" },
        new { id = "Child", mode = "Child" },
        new { id = "Both", mode = "Both" },
        new { id = "None", mode = "None" }
    };
    ViewBag.dropdata = dropData;
    return View();
}