public IActionResult Index()
{
    QueryBuilderRule rule = new QueryBuilderRule()
    {
        Condition = "and",
        Rules = new List<QueryBuilderRule>()
        {
            new QueryBuilderRule { Label="Employee ID", Field="EmployeeID", Type="number", Operator="equal", Value = 1 },
            new QueryBuilderRule { Label="Title", Field="Title", Type="string", Operator="equal", Value = "Sales Manager" }
        }
    };
    ViewBag.rule = rule;
    return View();
}