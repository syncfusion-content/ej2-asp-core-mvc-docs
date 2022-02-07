public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    return View();
}

public List<PivotData> GetPivotData()
{
    List<PivotData> pivotData = new List<PivotData>();
    pivotData.Add(new PivotData { ProductID = "618-XW",  Country = "Canada", Sold = 90, Amount = 9219069});
    pivotData.Add(new PivotData { ProductID = "1111-GQ", Sold = 37, Amount = 1571126,  Country = "Australia" }); 
    pivotData.Add(new PivotData { ProductID = "330-BR", Sold = 31, Amount = 9523258,  Country = "Germany" }); 
    pivotData.Add(new PivotData { ProductID = "1035-VC", Sold = 86, Amount = 1004572,  Country = "United States" }); 
    pivotData.Add(new PivotData { ProductID = "36-SW", Sold = 73, Amount = 4532163,  Country = "United Kingdom" }); 
    pivotData.Add(new PivotData { ProductID = "71-AJ", Sold = 45, Amount = 1916052,  Country = "Germany" }); 
    pivotData.Add(new PivotData { ProductID = "980-PP", Sold = 85, Amount = 6586156,  Country = "Canada" }); 
    pivotData.Add(new PivotData { ProductID = "209-FB", Sold = 51, Amount = 6348087,  Country = "Australia" }); 
    pivotData.Add(new PivotData { ProductID = "428-PL", Sold = 65, Amount = 1365854,  Country = "Germany" }); 
    pivotData.Add(new PivotData { ProductID = "618-XW", Sold = 81, Amount = 6461768,  Country = "United States" }); 
    pivotData.Add(new PivotData { ProductID = "1111-GQ", Sold = 33, Amount = 6181560,  Country = "United Kingdom" }); 
    pivotData.Add(new PivotData { ProductID = "330-BR", Sold = 17, Amount = 611364,  Country = "Germany" }); 
    pivotData.Add(new PivotData { ProductID = "1035-VC", Sold = 41, Amount = 3688930,  Country = "Canada" }); 
    pivotData.Add(new PivotData { ProductID = "36-SW", Sold = 51, Amount = 4648920,  Country = "Australia" }); 
    pivotData.Add(new PivotData { ProductID = "71-AJ", Sold = 56, Amount = 4579862,  Country = "Germany" }); 
    pivotData.Add(new PivotData { ProductID = "980-PP", Sold = 25, Amount = 1249117,  Country = "United States" }); 
    pivotData.Add(new PivotData { ProductID = "209-FB", Sold = 60, Amount = 9603891,  Country = "United Kingdom" }); 
    pivotData.Add(new PivotData { ProductID = "428-PL", Sold = 31, Amount = 9548655,  Country = "Canada" }); 
    pivotData.Add(new PivotData { ProductID = "618-XW", Sold = 93, Amount = 7496742,  Country = "Australia" }); 
    pivotData.Add(new PivotData { ProductID = "1111-GQ", Sold = 62, Amount = 8692814,  Country = "Germany" }); 
    pivotData.Add(new PivotData { ProductID = "330-BR", Sold = 22, Amount = 4789234,  Country = "United States" }); 
    pivotData.Add(new PivotData { ProductID = "1035-VC", Sold = 61, Amount = 7927531,  Country = "United Kingdom" }); 
    pivotData.Add(new PivotData { ProductID = "36-SW", Sold = 68, Amount = 5440025,  Country = "Germany" }); 
    pivotData.Add(new PivotData { ProductID = "71-AJ", Sold = 87, Amount = 8097913,  Country = "Canada" }); 
    pivotData.Add(new PivotData { ProductID = "980-PP", Sold = 87, Amount = 1809071,  Country = "Australia" });
    pivotData.Add(new PivotData { ProductID = "209-FB", Sold = 96, Amount = 9893092,  Country = "Germany" });
    pivotData.Add(new PivotData { ProductID = "428-PL", Sold = 22, Amount = 8136252,  Country = "United States" }); 
    pivotData.Add(new PivotData { ProductID = "618-XW", Sold = 29, Amount = 9190577,  Country = "United Kingdom" }); 
    pivotData.Add(new PivotData { ProductID = "1111-GQ", Sold = 85, Amount = 5410172,  Country = "Germany" });
    return pivotData;
}

public class PivotData
{
    public int Sold { get; set; }
    public double Amount { get; set; }
    public string Country { get; set; }
    public string ProductID { get; set; }
}