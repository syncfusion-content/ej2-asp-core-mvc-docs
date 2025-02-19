public class IndexModel : PageModel
 {
    private static DataTable ordersTable = GetData();
    private static DataTable GetData()
    {
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[5] {
            new DataColumn("OrderID", typeof(int)),
            new DataColumn("CustomerID", typeof(string)),
            new DataColumn("EmployeeID", typeof(int)),
            new DataColumn("Freight", typeof(double)),
            new DataColumn("ShipCity", typeof(string)),
        });

        int code = 1000;
        int id = 0;
        for (int i = 1; i <= 15; i++)
        {
            dt.Rows.Add(code + 1, "ALFKI", id + 1, 2.3 * i, "New York");
            dt.Rows.Add(code + 2, "ANATR", id + 2, 3.3 * i, "Los Angeles");
            dt.Rows.Add(code + 3, "ANTON", id + 3, 4.3 * i, "Chicago");
            dt.Rows.Add(code + 4, "BLONP", id + 4, 5.3 * i, "Houston");
            dt.Rows.Add(code + 5, "BOLID", id + 5, 6.3 * i, "Miami");
            code += 5;
            id += 5;
        }
        return dt;
    }
    public ActionResult OnPostUrlDatasource([FromBody] DataManagerRequest dm)
    {
        IEnumerable DataSource = ordersTable.AsEnumerable()
            .Select(row => new
            {
                OrderID = row.Field<int>("OrderID"),
                CustomerID = row.Field<string>("CustomerID"),
                EmployeeID = row.Field<int?>("EmployeeID"),
                Freight = row.Field<double?>("Freight"),
                ShipCity = row.Field<string>("ShipCity")
            });

        DataOperations operation = new DataOperations();
        int count = DataSource.Cast<dynamic>().Count();
        if (dm.Skip != 0)
        {
            DataSource = operation.PerformSkip(DataSource, dm.Skip);
        }
        if (dm.Take != 0)
        {
            DataSource = operation.PerformTake(DataSource, dm.Take);
        }
        return dm.RequiresCounts ? new JsonResult(new { result = DataSource, count = count }) : new JsonResult(DataSource);
    }
    public JsonResult OnPostInsert([FromBody] ExpandoObject value)
    {
        if (value is not IDictionary<string, object> dict)
        {
            return new JsonResult(new { error = "Invalid data format" });
        }
        if (dict.TryGetValue("value", out var jsonElementObj) && jsonElementObj is JsonElement jsonElement)
        {
            // Deserialize the JSON object into a Dictionary.
            var orderData = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonElement.GetRawText());
            if (orderData == null) // Check if the deserialization failed.
            {
                return new JsonResult(new { error = "Deserialization failed. Invalid JSON structure." });
            }
            DataRow newRow = ordersTable.NewRow(); // Create a new DataRow for the new entry.
            // Map fields from the incoming data to the DataRow.
            foreach (var col in ordersTable.Columns.Cast<DataColumn>())
            {
                if (orderData.TryGetValue(col.ColumnName, out var val)) // Check if the column exists in the incoming data.
                {
                    // If the value is null in the incoming data, set it to DBNull, otherwise convert it to the appropriate type.
                    newRow[col.ColumnName] = val.ValueKind == JsonValueKind.Null
                        ? DBNull.Value // Assign DBNull for null values.
                        : Convert.ChangeType(val.ToString(), col.DataType);
                }
            }
            // Insert the new row at the top of the DataTable.
            ordersTable.Rows.InsertAt(newRow, 0);
        }
        return new JsonResult(value); // Return the inserted value as a JSON response.
    }

    public JsonResult OnPostUpdate([FromBody] ExpandoObject value)
    {
        if (value is not IDictionary<string, object> dict)
        {
            return new JsonResult(new { error = "Invalid data format" });
        }
        if (dict.TryGetValue("value", out var jsonElementObj) && jsonElementObj is JsonElement jsonElement)
        {
            // Deserialize the JSON object into a Dictionary.
            var orderData = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonElement.GetRawText()) ?? new Dictionary<string, JsonElement>();

            // Check if the OrderID is present and is a number.
            if (orderData.TryGetValue("OrderID", out var orderIdElement) && orderIdElement.ValueKind == JsonValueKind.Number)
            {
                int orderId = orderIdElement.GetInt32(); // Get the OrderID as an integer.
                                                         // Find the row to update based on OrderID.
                var rowToUpdate = ordersTable.AsEnumerable().FirstOrDefault(row => row.Field<int>("OrderID") == orderId);

                if (rowToUpdate != null) // If the row exists.
                {
                    // Iterate over the columns of the DataTable.
                    foreach (var col in ordersTable.Columns.Cast<DataColumn>())
                    {
                        if (orderData.TryGetValue(col.ColumnName, out var val)) // Check if the column exists in the incoming data.
                        {
                            // If the value is null in the incoming data, set it to DBNull, otherwise convert it to the appropriate type.
                            rowToUpdate[col.ColumnName] = val.ValueKind == JsonValueKind.Null
                                ? DBNull.Value // Assign DBNull for null values.
                                : Convert.ChangeType(val.ToString(), col.DataType);
                        }
                    }
                }
            }
        }
        return new JsonResult(value); // Return the updated value as a JSON response.
    }
    public JsonResult OnPostDelete([FromBody] CRUDModel key)
    {
        if (key.key.HasValue)
        {
            // Find the row to delete based on OrderID.
            var rowToDelete = ordersTable.AsEnumerable()
                                      .FirstOrDefault(row => row.Field<int>("OrderID") == (int)key.key);
            if (rowToDelete != null)
            {
                ordersTable.Rows.Remove(rowToDelete); // Remove the row from the DataTable.
            }
        }
            return new JsonResult(key); // Returns the entire key object.
    }
}
public class CRUDModel
{
    public string? action { get; set; }
    public string? keyColumn { get; set; }
    public int? key { get; set; } 
    public IDictionary<string, object>? @params { get; set; }
}