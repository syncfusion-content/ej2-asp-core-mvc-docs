public ActionResult Update([FromBody]ICRUDModel<OrdersDetails> value)
{
    var ord = value.value;
    OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
    val.OrderID = ord.OrderID;
    val.EmployeeID = ord.EmployeeID;
    val.CustomerID = ord.CustomerID;
    val.Freight = ord.Freight;
    val.OrderDate = ord.OrderDate;
    val.ShipCity = ord.ShipCity;

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