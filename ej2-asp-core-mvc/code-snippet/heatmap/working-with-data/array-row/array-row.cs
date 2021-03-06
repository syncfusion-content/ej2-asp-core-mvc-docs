public ActionResult ArrayRow()
{
    ViewBag.textStyle = new
     {
         size= "15px",
         fontWeight= "500",
         fontStyle= "Normal",
         fontFamily= "Segoe UI"
         };
         string[] xlabels = new string[12] { "China", "India", "Australia", "Mexico", "Canada", "Brazil",
                "USA", "UK", "Germany", "Russia", "France", "Japan"};
         ViewBag.xLabels = xlabels;
         string[] yLabels = new string[10] { "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017" };
         ViewBag.yLabels = yLabels;
         ViewBag.dataSource = GetDataSource();
         return View();
}

 private double[,] GetDataSource()
        {
            double[,] data = new double[12, 10]
            {
                {9.5, 2.2, 4.2, 8.2, -0.5, 3.2, 5.4, 7.4, 6.2, 1.4 },
                {4.3, 8.9, 10.8, 6.5, 5.1, 6.2, 7.6, 7.5, 6.1, 7.6},
                {3.9, 2.7, 2.5, 3.7, 2.6, 5.1, 5.8, 2.9, 4.5, 5.1},
                {2.4, -3.7, 4.1, 6.0, 5.0, 2.4, 3.3, 4.6, 4.3, 2.7},
                {2.0, 7.0, -4.1, 8.9, 2.7, 5.9, 5.6, 1.9, -1.7, 2.9},
                {5.4, 1.1, 6.9, 4.5, 2.9, 3.4, 1.5, -2.8, -4.6, 1.2},
                {-1.3, 3.9, 3.5, 6.6, 5.2, 7.7, 1.4, -3.6, 6.6, 4.3},
                {-1.6, 2.3, 2.9, -2.5, 1.3, 4.9, 10.1, 3.2, 4.8, 2.0},
                {10.8, -1.6, 4.0, 6.0, 7.7, 2.6, 5.6, -2.5, 3.8, -1.9},
                {6.2, 9.8, -1.5, 2.0, -1.5, 4.3, 6.7, 3.8, -1.2, 2.4},
                {1.2, 10.9, 4.0, -1.4, 2.2, 1.6, -2.6, 2.3, 1.7, 2.4},
                {5.1, -2.4, 8.2, -1.1, 3.5, 6.0, -1.3, 7.2, 9.0, 4.2}
            };
            return data;
 }