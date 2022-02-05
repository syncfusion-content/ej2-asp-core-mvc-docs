public ActionResult Formatting()
{
    var treeData = ShipmentData.GetShipmentData();
    ViewBag.datasource = treeData;
    return View();    
}
