public ActionResult Update(CRUDModel Object)
{
    var ord = Object.Value;
    OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
    val.OrderID = ord.OrderID;
    val.EmployeeID = ord.EmployeeID;
    val.CustomerID = ord.CustomerID;
    val.Freight = ord.Freight;
    val.OrderDate = ord.OrderDate;
    val.ShipCity = ord.ShipCity;

    return Json(Object.Value);
}

public class CRUDModel
{
    public List<OrdersDetails> Added { get; set; }

    public List<OrdersDetails> Changed { get; set; }

    public List<OrdersDetails> Deleted { get; set; }

    public OrdersDetails Value { get; set; }

    public int key { get; set; }

    public string action { get; set; }
}