public static List<DynamicList> DynamicOrders { get; set; } = new List<DynamicList>();

public IActionResult Index()
{
    DynamicOrders = Enumerable.Range(1, 75).Select((x) =>
    {
        dynamic d = new DynamicList();
        d.OrderID = 1000 + x;
        d.Customer = new DynamicList();
        d.Customer.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
        d.Customer.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
        d.Customer.ShipCountry = (new string[] { "USA", "UK", "Denmark", "Australia", "India" })[new Random().Next(5)];
        d.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
        d.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
        d.ShipCountry = (new string[] { "USA", "UK" })[new Random().Next(2)];
        d.Verified = (new bool[] { true, false })[new Random().Next(2)];
        return d;
    }).Cast<DynamicList>().ToList<DynamicList>();
    ViewBag.DynamicData = DynamicOrders;
    return View();
}

public class DynamicList : DynamicObject
{
    private List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
        string name = binder.Name;
        var property = properties.Find(p => p.Key == name);
        result = property.Value;
        return property.Key != null;
    }

    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
        string name = binder.Name;
        var property = properties.Find(p => p.Key == name);
        if (property.Key != null)
        {
            properties.Remove(property);
        }

        properties.Add(new KeyValuePair<string, object>(name, value));
        return true;
    }


    public override IEnumerable<string> GetDynamicMemberNames()
    {
        return properties.ConvertAll(p => p.Key);
    }
}