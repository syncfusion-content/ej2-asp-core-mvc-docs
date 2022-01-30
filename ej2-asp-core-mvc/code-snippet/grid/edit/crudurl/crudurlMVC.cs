 
public ActionResult UrlDatasource(DataManagerRequest dm)
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

public ActionResult CrudUpdate([FromBody]CRUDModel myobjext)
{
    if(myobjext.action == "update")
    {
        var ord = myobjext.Value;
        OrdersDetails val = orddata.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
        val.OrderID = ord.OrderID;
        val.EmployeeID = ord.EmployeeID;
        val.CustomerID = ord.CustomerID;
        val.Freight = ord.Freight;
        val.OrderDate = ord.OrderDate;
        val.ShipCity = ord.ShipCity;
        val.ShipAddress = ord.ShipAddress;
        val.ShippedDate = ord.ShippedDate;
        return Json(myobjext.Value);

    } 
    else if (myobjext.action == "insert")
    {
        orddata.Insert(0, myobjext.Value);
        return Json(new { data = myobjext.Value });
    } 
    else
    {
        orddata.Remove(orddata.Where(or => or.OrderID == int.Parse(myobjext.key.ToString())).FirstOrDefault());
        return Json(new { data = myobjext.Value });
    }
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