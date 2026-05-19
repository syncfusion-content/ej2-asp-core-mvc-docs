public IActionResult Index()
{
    var data = PivotDataSource.GetPivotData();
    ViewBag.DataSource = data;
    return View();
}

public class PivotData
{
    public int Sold { get; set; }
    public double Amount { get; set; }
    public string Country { get; set; }
    public string Products { get; set; }
    public string Year { get; set; }
    public string Quarter { get; set; }
}

public static class PivotDataSource
{
    public static List<PivotData> GetPivotData()
    {
        return new List<PivotData>
        {
            new PivotData { Country = "France", Products = "Bike", Year = "FY 2025", Quarter = "Q1", Sold = 10, Amount = 1000 },
            new PivotData { Country = "France", Products = "Van", Year = "FY 2025", Quarter = "Q2", Sold = 15, Amount = 2000 },
            new PivotData { Country = "Germany", Products = "Bike", Year = "FY 2025", Quarter = "Q1", Sold = 8, Amount = 900 },
            new PivotData { Country = "Germany", Products = "Car", Year = "FY 2026", Quarter = "Q3", Sold = 20, Amount = 3000 },
            new PivotData { Country = "United States", Products = "Van", Year = "FY 2026", Quarter = "Q4", Sold = 12, Amount = 1500 }
        };
    }
}