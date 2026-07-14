public IActionResult Index()
{
    ViewBag.dataSource = GenerateData(10000);
    ViewBag.bufferSizes = new List<object>
    {
        new { text = "2 Rows", value = 2 },
        new { text = "3 Rows", value = 3 },
        new { text = "5 Rows", value = 5 },
        new { text = "8 Rows", value = 8 },
        new { text = "10 Rows", value = 10 }
    };
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
