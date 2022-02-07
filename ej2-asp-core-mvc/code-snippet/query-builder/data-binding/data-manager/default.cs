public ActionResult Index()
    {
          QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="Category", Field="Category", Type="string", Operator="equal", Value = "Laptop" }
                }
            };

            ViewBag.rule = rule;
            // hardwareData is referred from MVC sample browser.
            ViewBag.DataSource = QueryBuilderData.hardwareData;
            return View();
    }