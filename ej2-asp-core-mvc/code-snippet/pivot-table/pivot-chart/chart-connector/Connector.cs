public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.position = Position;
    return View();
}

public PivotViewPivotChartDataLabel Position = new PivotViewPivotChartDataLabel { Position = "OutSide" };
