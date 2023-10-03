public ActionResult TextStyle()
{
    string[] xlabels = new string[] { "Actual<br>Accept", "Actual<br>Reject" };
    ViewBag.xLabels = xlabels;
    string[] yLabels = new string[] { "Actual<br>Accept", "Actual<br>Reject" };
    ViewBag.yLabels = yLabels;
    ViewBag.dataSource = GetDataSource();
    return View();
}

 private double[,] GetDataSource()
 {
    double[,] dataSource = new double[,]
    {
        {1, 76},
        {19, 3}
    };
    return dataSource;
 }