public IActionResult Index()
{
    var tree = TreeData.GetDefaultData();
    ViewBag.dataSource = tree;
    return View();
}

public ActionResult Editpartial(TreeData value,bool isedit)
{
    ViewBag.prioritydata = new List<object>() { 
        new { text = "Normal", value= "Normal"},
        new { text = "Critical", value= "Critical"},
        new { text = "Low", value= "Low"},
        new { text = "High", value= "High"},
    };
    return PartialView("editpartial", value);
}