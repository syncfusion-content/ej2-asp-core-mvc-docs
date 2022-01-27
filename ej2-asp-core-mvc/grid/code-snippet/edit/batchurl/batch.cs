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

public ActionResult BatchUpdate(string action, CRUDModel batchmodel)
{
    if (batchmodel.Changed != null)
    {
        for (var i = 0; i < batchmodel.Changed.Count(); i++)
        {
            var ord = batchmodel.Changed[i];
            OrdersDetails val = orddata.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            val.ShipAddress = ord.ShipAddress;
            val.ShippedDate = ord.ShippedDate;
        }
    }

    if (batchmodel.Deleted != null) 
    { 
        for (var i = 0; i < batchmodel.Deleted.Count(); i++)
        {
            orddata.Remove(orddata.Where(or => or.OrderID == batchmodel.Deleted[i].OrderID).FirstOrDefault());
        }
    }

    if (batchmodel.Added != null) 
    { 
        for (var i = 0; i < batchmodel.Added.Count(); i++)
        {
            orddata.Insert(0, batchmodel.Added[i]);
        }
    }
    var data = orddata.ToList();
    return Json(data, JsonRequestBehavior.AllowGet);
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