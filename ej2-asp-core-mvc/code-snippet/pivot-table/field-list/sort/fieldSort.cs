public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;    
    return View();
}

public List<PivotData> GetPivotData()
{
    List<PivotData> pivotData = new List<PivotData>();
    pivotData.Add(new PivotData { Sold = 31, Amount = 52824, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 51, Amount = 86904, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 90, Amount = 153360, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 25, Amount = 42600, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 27, Amount = 46008, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 49, Amount = 83496, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 95, Amount = 161880, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 67, Amount = 114168, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 75, Amount = 127800, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 67, Amount = 114168, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 69, Amount = 117576, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 90, Amount = 153360, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 16, Amount = 27264, Country = "France", Products = "Mountain Bikes", Year = "FY 2018", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 83, Amount = 124422, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 57, Amount = 85448, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 20, Amount = 29985, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 67, Amount = 70008, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 89, Amount = 60496, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 75, Amount = 801880, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 57, Amount = 204168, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 75, Amount = 737800, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 87, Amount = 884168, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 39, Amount = 729576, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 90, Amount = 38860, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 93, Amount = 139412, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 51, Amount = 92824, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 61, Amount = 76904, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 70, Amount = 43360, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 85, Amount = 62600, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 97, Amount = 86008, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 69, Amount = 93496, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 45, Amount = 301880, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 77, Amount = 404168, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 15, Amount = 137800, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 37, Amount = 184168, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 49, Amount = 89576, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 40, Amount = 33360, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 96, Amount = 77264, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2018", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 23, Amount = 24422, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 67, Amount = 75448, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 70, Amount = 52345, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 13, Amount = 135612, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 57, Amount = 90008, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 29, Amount = 90496, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 45, Amount = 301880, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 77, Amount = 404168, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 15, Amount = 137800, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 37, Amount = 184168, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 99, Amount = 829576, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 80, Amount = 38360, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 91, Amount = 67824, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 81, Amount = 99904, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 70, Amount = 49360, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 65, Amount = 69600, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 57, Amount = 90008, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 29, Amount = 90496, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 85, Amount = 391880, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 97, Amount = 904168, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 85, Amount = 237800, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 77, Amount = 384168, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 99, Amount = 829576, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 80, Amount = 38360, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 76, Amount = 97264, Country = "United States", Products = "Mountain Bikes", Year = "FY 2018", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 53, Amount = 94422, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 90, Amount = 45448, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 29, Amount = 92345, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 67, Amount = 235612, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 97, Amount = 90008, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 79, Amount = 90496, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 95, Amount = 501880, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q3" });
    pivotData.Add(new PivotData { Sold = 97, Amount = 104168, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q4" });
    pivotData.Add(new PivotData { Sold = 95, Amount = 837800, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q1" });
    pivotData.Add(new PivotData { Sold = 87, Amount = 684168, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q2" });
    pivotData.Add(new PivotData { Sold = 109, Amount = 29576, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q3" });
    return pivotData;
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