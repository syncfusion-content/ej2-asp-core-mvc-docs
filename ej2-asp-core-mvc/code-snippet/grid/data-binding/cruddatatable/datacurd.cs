public static DataTable ordersTable { get; set; }
public DataTable GetData()
{
    DataTable dt = new DataTable();
    dt.Columns.AddRange(new DataColumn[3] {
        new DataColumn("OrderID", typeof(long)),
        new DataColumn("CustomerID", typeof(string)),
        new DataColumn("EmployeeID", typeof(int)),
    });
    int code = 1000;
    int id = 0;
    for (int i = 1; i <= 15; i++)
    {
        dt.Rows.Add(code + 1, "ALFKI", id + 1);
        dt.Rows.Add(code + 2, "ANATR", id + 2);
        dt.Rows.Add(code + 3, "ANTON", id + 3);
        dt.Rows.Add(code + 4, "BLONP", id + 4);
        dt.Rows.Add(code + 5, "BOLID", id + 5);
        code += 5;
        id += 5;
    }
    return dt;
}

public ActionResult OnPostUrlDatasource([FromBody] DataManagerRequest dm)
 {
    if (ordersTable == null)
    {
        ordersTable = GetData(); // Initialize if not already
    }
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
     return dm.RequiresCounts ? new JsonResult(new { result = DataSource, count = count, aggregate = aggregate }) : new JsonResult(DataSource);
 }

 public ActionResult OnPostUpdate([FromBody] ExpandoObject value)
 {
        DataRow newRow = ordersTable.NewRow();
    foreach (var item in value)
    {
        newRow[item.Key] = item.Value ?? DBNull.Value;
    }
    ordersTable.Rows.InsertAt(newRow, 0);
     //Here you can Update a record based on your scenario
     return new JsonResult(value);
 }


 public ActionResult OnPostInsert([FromBody] ExpandoObject value)
 {
        var data = (IDictionary<string, object>)value;
    var rowToUpdate = ordersTable.AsEnumerable()
                .FirstOrDefault(row => row.Field<long>("OrderID") == Convert.ToInt64(data["OrderID"]));
    if (rowToUpdate != null)
    {
        foreach (var item in data)
        {
            rowToUpdate[item.Key] = item.Value ?? DBNull.Value;
        }
    }
     //Here you can Insert a record based on your scenario
     return new JsonResult(value);
 }


 public ActionResult OnPostDelete(int key)
 {
        if (ordersTable == null)
    {
        ordersTable = GetData(); 
    }
    DataRow rowToRemove = null;
    long orderId = Convert.ToInt64(key);
    foreach (DataRow row in ordersTable.Rows)
    {
        if (row.ItemArray[0] != null && (long)row.ItemArray[0] == orderId)
        {
            rowToRemove = row;
            break;
        }
    }
    if (rowToRemove != null)
    {
        ordersTable.Rows.Remove(rowToRemove);
    }
     //Here you can Delete a record based on your scenario
     return new JsonResult(key);
 }