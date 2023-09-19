public static List<DynamicDictionary> DynamicOrders { get; set; } = new List<DynamicDictionary>();

protected IActionResult Index()
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
    ViewBag.DynamicData = DynamicOrders;
    return View();
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