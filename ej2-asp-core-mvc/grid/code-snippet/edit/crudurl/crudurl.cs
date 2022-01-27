 
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

public ActionResult CrudUpdate([FromBody]ICRUDModel<OrdersDetails> value, string action)
{
    if (value.action == "update")
    {
        var ord = value.value;
        OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
        val.OrderID = ord.OrderID;
        val.EmployeeID = ord.EmployeeID;
        val.CustomerID = ord.CustomerID;
        val.Freight = ord.Freight;
        val.OrderDate = ord.OrderDate;
        val.ShipCity = ord.ShipCity;
    }
    else if (value.action == "insert")
    {
        OrdersDetails.GetAllRecords().Insert(0, value.value);
    }
    else if (value.action == "remove")
    {
        OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == int.Parse(value.key.ToString())).FirstOrDefault());
        return Json(value);
    }
    return Json(value.value);
}

public class ICRUDModel<T> where T : class
{
    public string action { get; set; }

    public string table { get; set; }

    public string keyColumn { get; set; }

    public object key { get; set; }

    public T value { get; set; }

    public List<T> added { get; set; }

    public List<T> changed { get; set; }

    public List<T> deleted { get; set; }

    public IDictionary<string, object> @params { get; set; }
}