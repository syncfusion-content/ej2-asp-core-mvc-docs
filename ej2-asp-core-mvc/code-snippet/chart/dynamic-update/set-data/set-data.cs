public ActionResult Index()
{
    List<DynamicChartData> chartData = new List<DynamicChartData>
    {
        new DynamicChartData{ x= "Jewellery",          y= 75 },
        new DynamicChartData{ x= "Shoes",              y= 45 },
        new DynamicChartData{ x= "Footwear",           y= 73 },
        new DynamicChartData{ x= "Pet Services",       y= 53 },
        new DynamicChartData{ x= "Business Clothing",  y= 85 },
        new DynamicChartData{ x= "Office Supplies",    y= 68 },
        new DynamicChartData{ x= "Food",               y= 45 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class DynamicChartData
{
    public string x;
    public double y;
}