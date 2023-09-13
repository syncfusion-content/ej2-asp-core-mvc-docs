public static List<DynamicDictionary> DynamicOrders { get; set; } = new List<DynamicDictionary>();

public IActionResult Index()
{
    getDynamicDatas();
    return View();
}

public IActionResult Insert([FromBody] CRUDModel<DynamicDictionary> value)
{
    DynamicOrders.Insert(0, value.Value);
    return Json(value.Value);
}

public IActionResult Update([FromBody] CRUDModel<DynamicDictionary> value)
{
    if (value != null && value.Value != null)
    {
        var orderIDToUpdate = Convert.ToInt32(value.Key);

        var existingOrder = DynamicOrders.FirstOrDefault(order =>
        {
            if (order is DynamicDictionary dynamicDict &&
                dynamicDict.dictionary.TryGetValue("OrderID", out var orderIDValue))
            {
                var orderID = Convert.ToInt32(orderIDValue);
                return orderID == orderIDToUpdate;
            }

            return false;
        });

        if (existingOrder != null)
        {
            DynamicOrders.Remove(existingOrder);
            DynamicOrders.Insert(0, value.Value);
        }
    }

    return Json(value.Value);
}

public IActionResult Remove([FromBody] CRUDModel<DynamicDictionary> value)
{
    if (value != null)
    {
        var orderIDToDelete = Convert.ToInt32(value.Key);
        var itemToRemove = DynamicOrders.FirstOrDefault(order =>
        {
            if (order is DynamicDictionary dynamicDict &&
                dynamicDict.dictionary.TryGetValue("OrderID", out var orderIDValue))
            {
                var orderID = Convert.ToInt32(orderIDValue);
                return orderID == orderIDToDelete;
            }

            return false;
        });


        if (itemToRemove != null)
        {
            DynamicOrders.Remove(itemToRemove);
        }
    }

    return Json(value);
}

 public class CRUDModel
{
    public List<DynamicDictionary> Added { get; set; }
    public List<DynamicDictionary> Changed { get; set; }
    public List<DynamicDictionary> Deleted { get; set; }
    public DynamicDictionary Value { get; set; }
    public int key { get; set; }
    public string action { get; set; }
}

public IActionResult UrlDataSource([FromBody] DataManagerRequest dm)
{
    IEnumerable DataSource = DynamicOrders;
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
    int count = DataSource.Cast<DynamicDictionary>().Count();
    if (dm.Select != null)
    {
        DataSource = operation.PerformSelect(DataSource, dm.Select);  
        DataSource = DataSource.Cast<DynamicDictionary>().Distinct().AsEnumerable(); 
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

protected List<DynamicDictionary> getDynamicDatas()
{
    string[] customerIDs = { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" };
    string[] shipCountrys = { "USA", "UK", "Denmark", "Australia", "India" };
    DynamicOrders = Enumerable.Range(1, 5).Select((x) =>
    {
        dynamic d = new DynamicDictionary();
        d.OrderID = 1000 + x;
        d.CustomerID = customerIDs[x % customerIDs.Length];
        d.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
        d.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
        d.ShipCountry = shipCountrys[x % shipCountrys.Length];
        return d;
    }).Cast<DynamicDictionary>().ToList<DynamicDictionary>();

    return DynamicOrders;
}

public class DynamicDictionary : DynamicObject
{
    public Dictionary<string, object> dictionary = new Dictionary<string, object>();

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
        string name = binder.Name;
        return dictionary.TryGetValue(name, out result);
    }
    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
        dictionary[binder.Name] = value;
        return true;
    }

    public override System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames()
    {
        return this.dictionary?.Keys;
    }

}