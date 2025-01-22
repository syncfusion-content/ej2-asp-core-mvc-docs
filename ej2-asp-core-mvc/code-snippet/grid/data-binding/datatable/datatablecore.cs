public void OnGet()
{
    DataTable ordersTable = new DataTable("Orders");
    ordersTable.Columns.AddRange(new DataColumn[5]
    {
        new DataColumn("OrderID", typeof(long)),
        new DataColumn("CustomerID", typeof(string)),
        new DataColumn("Freight", typeof(decimal)),
        new DataColumn("OrderDate", typeof(DateTime)),
        new DataColumn("ShipCity", typeof(string))
    });

    // Sample data to populate the DataTable
    ordersTable.Rows.Add(10001, "ALFKI", 29.75m, new DateTime(1991, 05, 15), "Berlin");
    ordersTable.Rows.Add(10002, "ANATR", 15.00m, new DateTime(1990, 04, 04), "Madrid");
    ordersTable.Rows.Add(10003, "ANTON", 22.50m, new DateTime(1957, 11, 30), "London");
    ordersTable.Rows.Add(10004, "BLONP", 40.25m, new DateTime(1930, 10, 22), "Paris");
    ordersTable.Rows.Add(10005, "BOLID", 19.95m, new DateTime(1953, 02, 18), "New York");
    ordersTable.Rows.Add(10006, "VINET", 55.00m, new DateTime(1997, 01, 21), "Toulouse");
    ordersTable.Rows.Add(10007, "TOMSP", 80.50m, new DateTime(2000, 06, 17), "London");
    ordersTable.Rows.Add(10008, "MORGK", 45.25m, new DateTime(1996, 03, 30), "Berlin");
    ordersTable.Rows.Add(10009, "RICSU", 30.15m, new DateTime(1995, 05, 11), "Madrid");
    ordersTable.Rows.Add(10010, "SUPRD", 90.00m, new DateTime(1999, 08, 23), "Paris");
    ViewData["DataSource"] = ordersTable
}
