public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    return View();
}

public List<PivotData> GetPivotData()
{
    List<PivotData> pivotData = new List<PivotData>();
    pivotData.Add(new PivotData { Amount = 100, Country = "Canada", Date = "FY 2005", Products = "Bike", Quantity = 2, State = "Alberta" });
    pivotData.Add(new PivotData { Amount = 200, Country = "Canada", Date = "FY 2006", Products = "Van", Quantity = 3, State = "British Columbia" });
    pivotData.Add(new PivotData { Amount = 150, Country = "United States", Date = "FY 2006", Products = "Car", Quantity = 3, State = "New Mexico" });
    pivotData.Add(new PivotData { Amount = 200, Country = "United States", Date = "FY 2005", Products = "Bike", Quantity = 4, State = "New York" });
    return pivotData;
}

public class PivotData
{
    public int Quantity { get; set; }
    public double Amount { get; set; }
    public string Country { get; set; }
    public string Products { get; set; }
    public string Date { get; set; }
    public string State { get; set; }
}