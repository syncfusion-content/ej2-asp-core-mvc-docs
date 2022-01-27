public ActionResult UrlDatasource(DataManagerRequest dm)
{
    dt.Columns.AddRange(new DataColumn[4] { new DataColumn("OrderID", typeof(long)),
    new DataColumn("CustomerID", typeof(string)),
    new DataColumn("EmployeeID",typeof(int)),
    new DataColumn("OrderDate",typeof(DateTime))
    });
    int code = 100;
    for (int i = 1; i < 10; i++)
    {
        dt.Rows.Add(code + 1, "ALFKI", i + 0, new DateTime(1991, 05, 15));
        dt.Rows.Add(code + 2, "ANATR", i + 2, new DateTime(1990, 04, 04));
        dt.Rows.Add(code + 3, "ANTON", i + 1, new DateTime(1957, 11, 30));
        dt.Rows.Add(code + 4, "BLONP", i + 3, new DateTime(1930, 10, 22));
        dt.Rows.Add(code + 5, "BOLID", i + 4, new DateTime(1953, 02, 18));
        code += 5;
    }
    IEnumerable DataSource = Utils.DataTableToJson(dt);
    DataOperations operation = new DataOperations();
    if (dm.Search != null && dm.Search.Count > 0)
    {
        DataSource = operation.PerformSearching(DataSource, dm.Search);  //Search
    }
    if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
    {
        DataSource = operation.PerformSorting(DataSource, dm.Sorted);
    }
    if (dm.Where != null && dm.Where.Count > 0) //Filtering
    {
        DataSource = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
    }
    List<string> str = new List<string>();
    if (dm.Aggregates != null)
    {
        for (var i = 0; i < dm.Aggregates.Count; i++)
            str.Add(dm.Aggregates[i].Field);
    }
    IEnumerable aggregate = operation.PerformSelect(DataSource, str);
    int count = DataSource.Cast<object>().Count();
    if (dm.Skip != 0)
    {
        DataSource = operation.PerformSkip(DataSource, dm.Skip);   //Paging
    }
    if (dm.Take != 0)
    {
        DataSource = operation.PerformTake(DataSource, dm.Take);
    }
    return dm.RequiresCounts ? Json(new { result = DataSource, count = count, aggregate = aggregate }) : Json(DataSource);
}