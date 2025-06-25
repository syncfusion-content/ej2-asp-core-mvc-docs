public ActionResult Index()
{
    return View();
}

public class PivotData
{
    public string ProductID { get; set; }
    public string Year { get; set; }
    public double Sold { get; set; }
    public double Price { get; set; }

    public static List<PivotData> GetPivotData(int count)
    { 
        var result = new List<PivotData>();
        int dt = 0;

        for (int i = 1; i <= count; i++)
        {
            dt++;
            string round = i.ToString().PadLeft(5, '0');
            result.Add(new PivotData
            {
                ProductID = "PRO-" + round,
                Year = "FY " + (dt + 2013),
                Price = new Random(Guid.NewGuid().GetHashCode()).Next(5000, 10001),
                Sold = new Random(Guid.NewGuid().GetHashCode()).Next(10, 91),
            });

            if (dt / 4 == 1)
                dt = 0;
        }
        return result;
    }
}