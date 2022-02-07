public ActionResult Legend()
{
    ViewBag.textStyle = new
     {
         size= "15px",
         fontWeight= "500",
         fontStyle= "Normal",
         fontFamily= "Segoe UI"
         };
         string[] xlabels = new string[12] { "Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne", "Paul", "Karin", "Mario" };
         ViewBag.xLabels = xlabels;
         string[] yLabels = new string[6] { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
         ViewBag.yLabels = yLabels;
         ViewBag.dataSource = GetDataSource();
         return View();
}

 private int[,] GetDataSource()
 {
     int[,] data = new int[,]
            {
                {73000, 39000, 26000, 39000, 94000, 0},
                {93000, 58000, 53000, 38000, 26000, 68000},
                {99000, 28000, 22000, 4000, 66000, 9000},
                {14000, 26000, 97000, 69000, 69000, 3000},
                {7000, 46000, 47000, 47000, 88000, 6000},
                {41000, 55000, 73000, 23000, 3000, 79000},
                {56000, 69000, 21000, 86000, 3000, 33000},
                {45000, 7000, 53000, 81000, 95000, 79000},
                {60000, 77000, 74000, 68000, 88000, 51000},
                {25000, 25000, 10000, 12000, 78000, 14000},
                {25000, 56000, 55000, 58000, 12000, 82000},
                {74000, 33000, 88000, 23000, 86000, 59000}
            };
            return data;
 }