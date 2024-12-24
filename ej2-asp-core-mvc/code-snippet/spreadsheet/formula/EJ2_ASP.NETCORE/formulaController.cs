public IActionResult Index()
{
   List<object> data = new List<object>()
   {
      new { Category= "Household Utilities",  MonthlySpend= "=C3/12",  AnnualSpend= "3000",  LastYearSpend= "3000",  PercentageChange= "=C3/D3", AverageChange= "=7.9/E3"},
      new { Category= "Food",  MonthlySpend= "=C4/12",  AnnualSpend= "2500",  LastYearSpend= "2250",  PercentageChange= "=C4/D4", AverageChange= "=7.9/E4"},
      new { Category= "Gasoline",  MonthlySpend= "=C5/12",  AnnualSpend= "1500",  LastYearSpend= "1200",  PercentageChange= "=C5/D5", AverageChange= "=7.9/E5"},
      new { Category= "Clothes",  MonthlySpend= "=C6/12",  AnnualSpend= "1200",  LastYearSpend= "1000",  PercentageChange= "=C6/D6", AverageChange= "=7.9/E6"},
      new { Category= "Insurance",  MonthlySpend= "=C7/12",  AnnualSpend= "1500",  LastYearSpend= "1500",  PercentageChange= "=C7/D7", AverageChange= "=7.9/E7"},
      new { Category= "Taxes",  MonthlySpend= "=C8/12",  AnnualSpend= "3500",  LastYearSpend= "3500",  PercentageChange= "=C8/D8", AverageChange= "=7.9/E8"},
      new { Category= "Entertainment",  MonthlySpend= "=C9/12",  AnnualSpend= "2000",  LastYearSpend= "2250",  PercentageChange= "=C9/D9", AverageChange= "=7.9/E9"},
      new { Category= "Vacation",  MonthlySpend= "=C10/12",  AnnualSpend= "1500",  LastYearSpend= "2000",  PercentageChange= "=C10/D10", AverageChange= "=7.9/E10"},
      new { Category= "Miscellaneous",  MonthlySpend= "=C11/12",  AnnualSpend= "1250",  LastYearSpend= "1558",  PercentageChange= "=C11/D11", AverageChange= "=7.9/E11"},
   };
   ViewBag.DefaultData = data;
   return View();
}