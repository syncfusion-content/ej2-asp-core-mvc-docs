 public ActionResult OnPostUrlDatasource([FromBody] DataManagerRequest dataManagerRequest)
{
    DataTable ordersTable = new DataTable("Orders");
    ordersTable.Columns.AddRange(new DataColumn[6]
    {
        new DataColumn("OrderID", typeof(long)),
        new DataColumn("CustomerID", typeof(string)),
        new DataColumn("Freight", typeof(decimal)),
        new DataColumn("OrderDate", typeof(DateTime)),
        new DataColumn("ShipCity", typeof(string)),
        new DataColumn("EmployeeID", typeof(int))
    });
    ordersTable.Rows.Add(10001, "ALFKI", 29.75m, new DateTime(1991, 05, 15), "Berlin", 1);
    ordersTable.Rows.Add(10002, "ANATR", 15.00m, new DateTime(1990, 04, 04), "Madrid", 2);
    ordersTable.Rows.Add(10003, "ANTON", 22.50m, new DateTime(1957, 11, 30), "London", 3);
    ordersTable.Rows.Add(10004, "BLONP", 40.25m, new DateTime(1930, 10, 22), "Paris", 4);
    ordersTable.Rows.Add(10005, "BOLID", 19.95m, new DateTime(1953, 02, 18), "New York", 5);
    ordersTable.Rows.Add(10006, "VINET", 55.00m, new DateTime(1997, 01, 21), "Toulouse", 6);
    ordersTable.Rows.Add(10007, "TOMSP", 80.50m, new DateTime(2000, 06, 17), "London", 7);
    ordersTable.Rows.Add(10008, "MORGK", 45.25m, new DateTime(1996, 03, 30), "Berlin", 8);
    ordersTable.Rows.Add(10009, "RICSU", 30.15m, new DateTime(1995, 05, 11), "Madrid", 9);
    ordersTable.Rows.Add(10010, "SUPRD", 90.00m, new DateTime(1999, 08, 23), "Paris", 10);
    IEnumerable DataSource = ordersTable.AsEnumerable()
    .Select(row => new
    {
        OrderID = row.Field<long>("OrderID"),
        CustomerID = row.Field<string>("CustomerID"),
        Freight = row.Field<decimal>("Freight"),
        OrderDate = row.Field<DateTime>("OrderDate"),
        ShipCity = row.Field<string>("ShipCity"),
        EmployeeID = row.Field<int>("EmployeeID")
    });
    DataOperations operation = new DataOperations();
    if (dataManagerRequest.Search != null && dataManagerRequest.Search.Count > 0)
    {
        DataSource = operation.PerformSearching(DataSource, dataManagerRequest.Search);
    }
    if (dataManagerRequest.Sorted != null && dataManagerRequest.Sorted.Count > 0)
    {
        DataSource = operation.PerformSorting(DataSource, dataManagerRequest.Sorted);
    }
    if (dataManagerRequest.Where != null && dataManagerRequest.Where.Count > 0)
    {
        DataSource = operation.PerformFiltering(DataSource, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
    }
    List<string> str = new List<string>();
    if (dataManagerRequest.Aggregates != null)
    {
        for (var i = 0; i < dataManagerRequest.Aggregates.Count; i++)
            str.Add(dataManagerRequest.Aggregates[i].Field);
    }
    IEnumerable aggregate = operation.PerformSelect(DataSource, str);
    int count = DataSource.Cast<object>().Count();
    if (dataManagerRequest.Skip != 0)
    {
        DataSource = operation.PerformSkip(DataSource, dataManagerRequest.Skip);
    }
    if (dataManagerRequest.Take != 0)
    {
        DataSource = operation.PerformTake(DataSource, dataManagerRequest.Take);
    }
    return dataManagerRequest.RequiresCounts ? new JsonResult(new { result = DataSource, count = count, aggregate = aggregate }) : new JsonResult(DataSource);
}