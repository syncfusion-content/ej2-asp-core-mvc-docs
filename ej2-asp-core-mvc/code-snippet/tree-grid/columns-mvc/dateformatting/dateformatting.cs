public ActionResult Dateformatting()
{
    var treeData = ShipmentData.GetShipmentData();
    ViewBag.datasource = treeData;
    return View();    
}
