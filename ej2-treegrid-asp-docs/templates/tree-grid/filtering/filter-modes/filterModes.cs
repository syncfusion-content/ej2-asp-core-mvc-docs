public ActionResult Index()
{
    var tree = TreeData.GetDefaultData();
    ViewBag.datasource = tree;
    ViewBag.dropdata = new List<object>() {
        new { id= "Parent", mode= "Parent" },
        new { id= "Child", mode= "Child" },
        new { id= "Both", mode= "Both" },
        new { id= "None", mode= "None" },
    };
    return View();
}