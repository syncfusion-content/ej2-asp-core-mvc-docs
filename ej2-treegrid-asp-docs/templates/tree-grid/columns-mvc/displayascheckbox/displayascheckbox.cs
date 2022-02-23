public ActionResult DisplayAsCheckbox()
{
    var treeData = TreeGridItems.GetTreeData();
    ViewBag.datasource = treeData;
    return View();    
}
