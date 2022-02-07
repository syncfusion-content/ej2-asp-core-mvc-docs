public IActionResult Index()
{
    QueryBuilderRule rule = new QueryBuilderRule()
    {
        Not = true,
        Condition = "and",
        Rules = new List<QueryBuilderRule>()
        {
            new QueryBuilderRule { Label="Employee ID", Field="EmployeeID", Type="number", Operator="equal", Value = 1 },
            new QueryBuilderRule { Label="LastName", Field="LastName", Type="string", Operator="equal", Value = "MALAN" },
            {
                new QueryBuilderRule {
                    Condition = "or",
                    Rules = new List<QueryBuilderRule>()
                    {
                        new QueryBuilderRule { Label="LastName", Field="LastName", Type="string", Operator="equal", Value = "MALAN" }
                    }
                }
            }
        }
    };
    ViewBag.rule = rule;
    return View();
}