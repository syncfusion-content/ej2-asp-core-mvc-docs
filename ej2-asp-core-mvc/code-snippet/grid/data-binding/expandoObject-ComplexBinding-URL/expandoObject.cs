public static List<ExpandoObject> ExpandoOrders { get; set; } = new List<ExpandoObject>();

public IActionResult Index()
{
    getExpandoDatas();
    return View();
}

public IActionResult Insert([FromBody] CRUDModel<ExpandoObject> value)
{
    ExpandoOrders.Insert(0, value.Value);
    return Json(value.Value);
}

public IActionResult Update([FromBody] CRUDModel<ExpandoObject> value)
{
    if (value != null && value.Value != null)
    {
        var orderIDToUpdate = Convert.ToInt32(value.Key);

        var existingOrder = ExpandoOrders.FirstOrDefault(order =>
        {
            if (order is IDictionary<string, object> orderDictionary &&
                orderDictionary.TryGetValue("OrderID", out var orderIDValue))
            {
                var orderID = Convert.ToInt32(orderIDValue);
                return orderID == orderIDToUpdate;
            }

            return false;
        });

        if (existingOrder != null)
        {
            ExpandoOrders.Remove(existingOrder);
            ExpandoOrders.Insert(0, value.Value);
        }
    }

    return Json(value.Value);
}

public IActionResult Remove([FromBody] CRUDModel<ExpandoObject> value)
{
    if (value != null)
    {
        var orderIDToDelete = Convert.ToInt32(value.Key);

        var itemToRemove = ExpandoOrders.FirstOrDefault(order =>
        {
            if (order is IDictionary<string, object> dictionary &&
                dictionary.TryGetValue("OrderID", out var orderIDValue))
            {
                var orderID = Convert.ToInt32(orderIDValue);
                return orderID == orderIDToDelete;
            }

            return false;
        });

        if (itemToRemove != null)
        {
            ExpandoOrders.Remove(itemToRemove);
        }
    }

    return Json(value);
}

public class CRUDModel
{
    public List<ExpandoObject> Added { get; set; }
    public List<ExpandoObject> Changed { get; set; }
    public List<ExpandoObject> Deleted { get; set; }
    public ExpandoObject Value { get; set; }
    public int key { get; set; }
    public string action { get; set; }
}

public IActionResult UrlDataSource([FromBody] DataManagerRequest dm)
{
    IEnumerable DataSource = ExpandoOrders;
    DataOperations operation = new DataOperations();

    if (dm.Search != null && dm.Search.Count > 0)
    {
        DataSource = operation.PerformSearching(DataSource, dm.Search);  //Search
    }
    if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
    {
        DataSource = operation.PerformSorting(DataSource, dm.Sorted);
    }
    if (dm.Where != null && dm.Where.Count > 0) //Filtering
    {
        DataSource = operation.PerformFiltering
            (DataSource, dm.Where, dm.Where[0].Operator);
    }
    int count = DataSource.Cast<ExpandoObject>().Count();
    if (dm.Select != null)
    {
        DataSource = operation.PerformSelect(DataSource, dm.Select);  
        DataSource = DataSource.Cast<ExpandoObject>().Distinct().AsEnumerable(); 
    }
    if (dm.Skip != 0)
    {
        DataSource = operation.PerformSkip(DataSource, dm.Skip);   //Paging
    }
    if (dm.Take != 0)
    {
        DataSource = operation.PerformTake(DataSource, dm.Take);
    }

    return dm.RequiresCounts ?
        Json(new { result = DataSource, count = count }) : Json(DataSource);
}

protected List<ExpandoObject> getExpandoDatas()
{
    string[] customerIDs = { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" };
    string[] shipCountrys = { "USA", "UK", "Denmark", "Australia", "India" };
    ExpandoOrders = Enumerable.Range(1, 5).Select((x) =>
    {
        dynamic d = new ExpandoObject();
        d.OrderID = 1000 + x;
        d.Customer = new ExpandoObject();
        d.Customer.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
        d.Customer.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
        d.Customer.ShipCountry = (new string[] { "USA", "UK", "Denmark", "Australia", "India" })[new Random().Next(5)];
        d.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
        d.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
        d.ShipCountry = (new string[] { "USA", "UK" })[new Random().Next(2)];
        d.Verified = (new bool[] { true, false })[new Random().Next(2)];
        return d;
    }).Cast<ExpandoObject>().ToList<ExpandoObject>();

    return ExpandoOrders;
}