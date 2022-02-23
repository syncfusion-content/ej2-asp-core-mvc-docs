public ActionResult Index()
{
    List<TabTabItem> tabItems = new List<TabTabItem>();
    tabItems.Add(new TabTabItem { Header = new TabHeader { Text = "Chart" }, Content = "#Content1" });
    tabItems.Add(new TabTabItem { Header = new TabHeader { Text = "Grid" }, Content = "#Content2" });
    tabItems.Add(new TabTabItem { Header = new TabHeader { Text = "Calender" }, Content = "#Content3" });
    ViewBag.items = tabItems;
    //chart data
    List<ColumnChartData> chartData = new List<ColumnChartData>
    {
        new ColumnChartData { x= "USA", yValue= 46 },
        new ColumnChartData { x= "GBR", yValue= 27 },
        new ColumnChartData { x= "CHN", yValue= 26 }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class ColumnChartData
{
    public string x;
    public double yValue;
}