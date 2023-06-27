public ActionResult TextStyle()
{
    ViewBag.textStyle = new
    {
        size= "15px",
        fontWeight= "500",
        fontStyle= "Normal",
        fontFamily= "Segoe UI"
    };
    ViewBag.axisTextStyle = new
    {
        color="Red",
        size= "15px",
        fontWeight= "650",
        fontStyle= "Normal",
        fontFamily= "Segoe UI",
        textAlignment = Syncfusion.EJ2.HeatMap.Alignment.Center,
        textOverflow = Syncfusion.EJ2.HeatMap.TextOverflow.Wrap
    };
    string[] xlabels = new string[] { "Month of Feburary 2023", "Month of March 2023", "Month of April 2023", "Month of May 2023", "Month of June 2023", "Month of July 2023", "Month of August 2023", "Month of September 2023", "Month of October 2023", "Month of November 2023", "Month of December 2023" };
    ViewBag.xLabels = xlabels;
    string[] yLabels = new string[] { "Ace Apparels", "Alpha Apparels", "RL Garments", "RRD Garments", "RRD Apparels", "RR Garments", "SR Garments" };
    ViewBag.yLabels = yLabels;
    ViewBag.dataSource = GetDataSource();
    return View();
}

 private double[,] GetDataSource()
 {
    double[,] dataSource = new double[,]
    {
        { 52, 65, 67, 45, 37, 52, 32 },
        { 68, 52, 63, 51, 30, 51, 51 },
        { 60, 50, 42, 53, 66, 70, 41 },
        { 66, 64, 46, 40, 47, 41, 45 },
        { 65, 42, 58, 32, 36, 44, 49 },
        { 54, 46, 61, 46, 40, 39, 41 },
        { 48, 46, 61, 47, 49, 41, 41 },
        { 69, 52, 41, 44, 41, 52, 46 },
        { 50, 59, 44, 43, 27, 42, 26 },
        { 47, 49, 66, 53, 50, 34, 31 },
        { 61, 40, 62, 26, 34, 54, 56 }
    };
    return dataSource;
 }