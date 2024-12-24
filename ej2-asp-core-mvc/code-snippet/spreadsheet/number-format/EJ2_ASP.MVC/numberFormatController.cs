public ActionResult Index()
{
      List<object> data = new List<object>()
   {
      new { Salesperson= "Jeffrey Burke",  RegionCovered= "Oklahoma",  February2019Sales= "28000",  CostofSales= "2460",  January2019Sales= "21238", PercentChange = ".32"},
      new { Salesperson= "Amy Fernandez",  RegionCovered= "North Carolina",  February2019Sales= "23138",  CostofSales= "1521",  January2019Sales= "23212", PercentChange = "0"},
      new { Salesperson= "Mark Hayes",  RegionCovered= "Massachusetts",  February2019Sales= "25092",  CostofSales= "1521",  January2019Sales= "20454", PercentChange = ".23"},
      new { Salesperson= "Judith Ray",  RegionCovered= "California",  February2019Sales= "21839",  CostofSales= "1923",  January2019Sales= "24619", PercentChange = "-.11"},
      new { Salesperson= "Rany Graham",  RegionCovered= "South Carolina",  February2019Sales= "23342",  CostofSales= "2397",  January2019Sales= "20045", PercentChange = ".16"},
      new { Salesperson= "Christina Foster",  RegionCovered= "Delaware",  February2019Sales= "23368",  CostofSales= "1500",  January2019Sales= "17537", PercentChange = ".33"},
      new { Salesperson= "Judy Green",  RegionCovered= "Texas",  February2019Sales= "21510",  CostofSales= "1657",  January2019Sales= "17537", PercentChange = "-.14"},
      new { Salesperson= "Paula Hall",  RegionCovered= "Virginia",  February2019Sales= "21314",  CostofSales= "2418",  January2019Sales= "18082", PercentChange = ".18"},
   };
   ViewBag.DefaultData = data;
   return View();
}