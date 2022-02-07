public IActionResult Index()
        {
           List<object> data = new List<object>()
            {
                new { Expense Type= "Housing", Projected Cost= "7000", Actual Cost= "7500", Difference= "-500" },
                new { Expense Type= "Transportation", Projected Cost= "500", Actual Cost= "500", Difference= "0" },
                new { Expense Type= "Insurance", Projected Cost= "1000", Actual Cost= "1000", Difference= "0" },
                new { Expense Type= "Food", Projected Cost= "2000", Actual Cost= "1800", Difference= "200" },
                new { Expense Type= "Pets", Projected Cost= "300", Actual Cost= "200", Difference= "100" },
                new { Expense Type= "Personel Care", Projected Cost= "500", Actual Cost= "500", Difference= "0" },
                new { Expense Type= "Loan", Projected Cost= "1000", Actual Cost= "1000", Difference= "0" },
                new { Expense Type= "Tax", Projected Cost= "200", Actual Cost= "200", Difference= "0" },
                new { Expense Type= "Savings", Projected Cost= "1000", Actual Cost= "900", Difference= "100" },
                new { Expense Type= "Total", Projected Cost= "13500", Actual Cost= "13600", Difference= "-100" },
            };
            ViewBag.DefaultData = data;
            return View();
        }