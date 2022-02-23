public ActionResult Minmax()
{
    var treeData = TreeGridItems.GetTreeData();
    ViewBag.datasource = treeData;
    return View();    
}
