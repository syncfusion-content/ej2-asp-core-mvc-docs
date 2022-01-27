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