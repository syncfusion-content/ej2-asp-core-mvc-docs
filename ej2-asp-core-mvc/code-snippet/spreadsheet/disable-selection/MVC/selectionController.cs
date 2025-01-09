public ActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { ExpenseType= "Housing", ProjectedCost= "7000", ActualCost= "7500", Difference= "-500" },
        new { ExpenseType= "Transportation", ProjectedCost= "500", ActualCost= "500", Difference= "0" },
        new { ExpenseType= "Insurance", ProjectedCost= "1000", ActualCost= "1000", Difference= "0" },
        new { ExpenseType= "Food", ProjectedCost= "2000", ActualCost= "1800", Difference= "200" },
        new { ExpenseType= "Pets", ProjectedCost= "300", ActualCost= "200", Difference= "100" },
        new { ExpenseType= "Personel Care", ProjectedCost= "500", ActualCost= "500", Difference= "0" },
        new { ExpenseType= "Loan", ProjectedCost= "1000", ActualCost= "1000", Difference= "0" },
        new { ExpenseType= "Tax", ProjectedCost= "200", ActualCost= "200", Difference= "0" },
        new { ExpenseType= "Savings", ProjectedCost= "1000", ActualCost= "900", Difference= "100" },
        new { ExpenseType= "Total", ProjectedCost= "13500", ActualCost= "13600", Difference= "-100" },
    };
    ViewBag.DefaultData = data;
    return View();
}