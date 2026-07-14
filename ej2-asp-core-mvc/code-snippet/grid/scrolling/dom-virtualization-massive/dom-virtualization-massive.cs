public IActionResult Index()
{
    ViewBag.dataSource = GenerateData(10000);
    return View();
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
