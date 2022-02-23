public IActionResult Index()
{
        QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRules>()
                {
                    new QueryBuilderRules { Label="Employee ID", Field="EmployeeID", Type="number", Operator="equal", Value = 1 },
                    new QueryBuilderRules { Label="Title", Field="Title", Type="string", Operator="equal", Value = "Sales Manager" }
                }
            };

            ViewBag.rule = rule;
            return view(); 
}