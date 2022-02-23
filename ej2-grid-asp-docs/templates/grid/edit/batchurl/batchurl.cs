public IActionResult UrlDatasource([FromBody]DataManagerRequest dm)
{
  IEnumerable DataSource = OrdersDetails.GetAllRecords();
  DataOperations operation = new DataOperations();
  int count = DataSource.Cast<OrdersDetails>().Count();
  if (dm.Skip != 0)
  {
    DataSource = operation.PerformSkip(DataSource, dm.Skip);   //Paging
  }
  if (dm.Take != 0)
  {
    DataSource = operation.PerformTake(DataSource, dm.Take);
  }
  return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource);
}

public IActionResult BatchUpdate([FromBody]CRUDModel batchmodel)
{
    if (batchmodel.Changed != null)
    {
        for (var i = 0; i < batchmodel.Changed.Count(); i++)
        {
            var ord = batchmodel.Changed[i];
            Orders val = order.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.ShipCity = ord.ShipCity;
        }
    }
    if (batchmodel.Deleted != null)
    {
        for (var i = 0; i < batchmodel.Deleted.Count(); i++)
        {
            order.Remove(order.Where(or => or.OrderID == batchmodel.Deleted[i].OrderID).FirstOrDefault());
        }
    }
    if (batchmodel.Added != null)
    {
        for (var i = 0; i < batchmodel.Added.Count(); i++)
        {
            order.Insert(0, batchmodel.Added[i]);
        }
    }
    var data = order.ToList();
    return Json(data);
}