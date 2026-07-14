public IActionResult Index()
{
    // For virtual scroll with server-side data, the DataManager will be configured in the view
    // to fetch data from a remote endpoint. This action just returns the view.
    return View();
}

// This action method can be used to provide data for virtual scrolling
public IActionResult DataSource([FromBody] DataManagerRequest dm)
{
    IEnumerable data = GenerateData(100000);
    DataOperations operations = new DataOperations();
    
    if (dm.Skip != 0)
    {
        data = operations.PerformSkip(data, dm.Skip);
    }
    if (dm.Take != 0)
    {
        data = operations.PerformTake(data, dm.Take);
    }
    
    return dm.RequiresCounts ? Json(new { result = data, count = 100000 }) : Json(data);
}

private List<object> GenerateData(int count)
{
    var customerNames = new[] { "VINET", "TOMSP", "HANAR", "VICTE", "SUPRD", "CHOPS", "RICSU", "WELLI", "HILAA", "ERNSH" };
    var cities = new[] { "Reims", "Münster", "Rio de Janeiro", "Lyon", "Charleroi", "Bern", "Genève", "Marseille", "Tsawassen", "Campinas" };
    var countries = new[] { "France", "Germany", "Brazil", "France", "Belgium", "Switzerland", "Switzerland", "France", "Canada", "Brazil" };
    var random = new Random();
    var data = new List<object>();
    
    for (int i = 0; i < count; i++)
    {
        var cityIndex = i % cities.Length;
        data.Add(new
        {
            OrderID = 10248 + i,
            CustomerID = customerNames[random.Next(customerNames.Length)],
            OrderDate = new DateTime(1996, 1, 1).AddDays(i % 365),
            Freight = Math.Round(random.NextDouble() * 100, 2),
            ShipCity = cities[cityIndex],
            ShipCountry = countries[cityIndex]
        });
    }
    return data;
}
