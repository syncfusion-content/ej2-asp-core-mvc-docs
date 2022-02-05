public ActionResult ColumnChooser()
{
    var treeData = TreeGridItems.GetTreeData();
    ViewBag.datasource = treeData;
    return View();    
}
