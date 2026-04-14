public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    return View();
}

public class PivotData
{
    public double Amount { get; set; }
    public string Country { get; set; }
    public string Date { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
    public string State { get; set; }
}

public List<PivotData> GetPivotData()
{
    List<PivotData> pivotData = new List<PivotData>();
    pivotData.Add(new PivotData { Amount = 100, Country = "Canada", Date = "FY 2024", Product = "Bike", Quantity = 2, State = "Alberta" });
    pivotData.Add(new PivotData { Amount = 200, Country = "Canada", Date = "FY 2024", Product = "Van", Quantity = 3, State = "British Columbia" });
    pivotData.Add(new PivotData { Amount = 200, Country = "Canada", Date = "FY 2025", Product = "Van", Quantity = 3, State = "British Columbia" });
    pivotData.Add(new PivotData { Amount = 100, Country = "Canada", Date = "FY 2025", Product = "Bike", Quantity = 2, State = "Alberta" });
    pivotData.Add(new PivotData { Amount = 150, Country = "Canada", Date = "FY 2024", Product = "Car", Quantity = 3, State = "New Mexico" });
    pivotData.Add(new PivotData { Amount = 200, Country = "Canada", Date = "FY 2024", Product = "Bike", Quantity = 4, State = "New York" });
    pivotData.Add(new PivotData { Amount = 150, Country = "United States", Date = "FY 2025", Product = "Car", Quantity = 3, State = "New Mexico" });
    pivotData.Add(new PivotData { Amount = 200, Country = "United States", Date = "FY 2024", Product = "Bike", Quantity = 4, State = "New York" });
    pivotData.Add(new PivotData { Amount = 150, Country = "United States", Date = "FY 2024", Product = "Car", Quantity = 3, State = "Alberta" });
    pivotData.Add(new PivotData { Amount = 150, Country = "United States", Date = "FY 2025", Product = "Car", Quantity = 3, State = "Alberta" });
    pivotData.Add(new PivotData { Amount = 200, Country = "United States", Date = "FY 2025", Product = "Van", Quantity = 3, State = "British Columbia" });
    pivotData.Add(new PivotData { Amount = 200, Country = "United States", Date = "FY 2025", Product = "Bike", Quantity = 4, State = "New York" });
    return pivotData;
}