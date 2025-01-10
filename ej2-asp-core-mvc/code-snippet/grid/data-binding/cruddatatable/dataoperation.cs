public ActionResult UrlDatasource(DataManagerRequest dm)
{
    DataTable ordersTable = new DataTable("Orders");
    ordersTable.Columns.AddRange(new DataColumn[6] // Adjusted to 6 columns
    {
        new DataColumn("OrderID", typeof(long)),
        new DataColumn("CustomerID", typeof(string)),
        new DataColumn("Freight", typeof(decimal)),
        new DataColumn("OrderDate", typeof(DateTime)),
        new DataColumn("ShipCity", typeof(string)),
        new DataColumn("EmployeeID", typeof(int)) // New column for EmployeeID
    });
    // Sample data to populate the DataTable
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
    IEnumerable DataSource = Utils.DataTableToJson(ordersTable);
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

public ActionResult Update(ExpandoObject value)
{
    //Here you can Update a record based on your scenario
    return Json(value, JsonRequestBehavior.AllowGet);
}

       
public ActionResult Insert(ExpandoObject value)
{
    //Here you can Insert a record based on your scenario
	return Json(value, JsonRequestBehavior.AllowGet);
}

		
public ActionResult Delete(int key)
{
    //Here you can Delete a record based on your scenario
    return Json(key, JsonRequestBehavior.AllowGet);
}