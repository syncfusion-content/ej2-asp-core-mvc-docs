public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    return View();
}

public List<PivotData> GetPivotData()
{
    List<PivotData> pivotData = new List<PivotData>();
    pivotData.Add(new PivotData { Sold = 31, In_Stock = 52824, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 51, In_Stock = 86904, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 90, In_Stock = 153360, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 25, In_Stock = 42600, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 27, In_Stock = 46008, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 49, In_Stock = 83496, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 95, In_Stock = 161880, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 67, In_Stock = 114168, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 75, In_Stock = 127800, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 67, In_Stock = 114168, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 69, In_Stock = 117576, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 90, In_Stock = 153360, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 16, In_Stock = 27264, Country = "France", Products = "Mountain Bikes", Year = "FY 2018", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 83, In_Stock = 124422, Country = "France", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 57, In_Stock = 85448, Country = "France", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 20, In_Stock = 29985, Country = "France", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 67, In_Stock = 70008, Country = "France", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 89, In_Stock = 60496, Country = "France", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 75, In_Stock = 801880, Country = "France", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 57, In_Stock = 204168, Country = "France", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 75, In_Stock = 737800, Country = "France", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 87, In_Stock = 884168, Country = "France", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 39, In_Stock = 729576, Country = "France", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 90, In_Stock = 38860, Country = "France", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 93, In_Stock = 139412, Country = "France", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 51, In_Stock = 92824, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 61, In_Stock = 76904, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 70, In_Stock = 43360, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 85, In_Stock = 62600, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 97, In_Stock = 86008, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 69, In_Stock = 93496, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 45, In_Stock = 301880, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 77, In_Stock = 404168, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 15, In_Stock = 137800, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 37, In_Stock = 184168, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 49, In_Stock = 89576, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 40, In_Stock = 33360, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 96, In_Stock = 77264, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2018", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 23, In_Stock = 24422, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 67, In_Stock = 75448, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 70, In_Stock = 52345, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 13, In_Stock = 135612, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 57, In_Stock = 90008, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 29, In_Stock = 90496, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 45, In_Stock = 301880, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 77, In_Stock = 404168, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 15, In_Stock = 137800, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 37, In_Stock = 184168, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 99, In_Stock = 829576, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 80, In_Stock = 38360, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 91, In_Stock = 67824, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 81, In_Stock = 99904, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 70, In_Stock = 49360, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 65, In_Stock = 69600, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 57, In_Stock = 90008, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 29, In_Stock = 90496, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 85, In_Stock = 391880, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 97, In_Stock = 904168, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 85, In_Stock = 237800, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 77, In_Stock = 384168, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 99, In_Stock = 829576, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 80, In_Stock = 38360, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 76, In_Stock = 97264, Country = "United States", Products = "Mountain Bikes", Year = "FY 2018", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 53, In_Stock = 94422, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 90, In_Stock = 45448, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 29, In_Stock = 92345, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 67, In_Stock = 235612, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 97, In_Stock = 90008, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 79, In_Stock = 90496, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 95, In_Stock = 501880, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q3" });
    pivotData.Add(new PivotData { Sold = 97, In_Stock = 104168, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Order_Source = "Q4" });
    pivotData.Add(new PivotData { Sold = 95, In_Stock = 837800, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q1" });
    pivotData.Add(new PivotData { Sold = 87, In_Stock = 684168, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q2" });
    pivotData.Add(new PivotData { Sold = 109, In_Stock = 29576, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Order_Source = "Q3" });
    return pivotData;
}

public class PivotData
{
    public int Sold { get; set; }
    public double In_Stock { get; set; }
    public string Country { get; set; }
    public string Products { get; set; }
    public string Year { get; set; }
    public string Order_Source { get; set; }
}