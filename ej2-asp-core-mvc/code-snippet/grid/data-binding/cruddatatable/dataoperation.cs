public class HomeController : Controller
{

    private static DataTable ordersTable = GetData();

    public ActionResult Index()
    {
        return View();
    }
    // ✅ Method to populate the DataTable with initial data
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

    // ✅ Data Source for Syncfusion Grid
    public ActionResult UrlDatasource(DataManagerRequest dm)
    {
        IEnumerable DataSource = Utils.DataTableToJson(ordersTable);
        DataOperations operation = new DataOperations();
        int count = DataSource.Cast<object>().Count();

        if (dm.Skip != 0)
        {
            DataSource = operation.PerformSkip(DataSource, dm.Skip);
        }
        if (dm.Take != 0)
        {
            DataSource = operation.PerformTake(DataSource, dm.Take);
        }

        return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource);
    }
    // ✅ Insert action (Adding new record at the **top**)
    public ActionResult Insert(ExpandoObject value)
    {
        if (value != null)
        {
            DataRow newRow = ordersTable.NewRow();
            var dict = (IDictionary<string, object>)value;

            newRow["OrderID"] = dict.ContainsKey("OrderID") ? dict["OrderID"] : 0;
            newRow["CustomerID"] = dict.ContainsKey("CustomerID") ? dict["CustomerID"].ToString() : string.Empty;
            newRow["EmployeeID"] = dict.ContainsKey("EmployeeID") ? Convert.ToInt32(dict["EmployeeID"]) : 0;
            newRow["Freight"] = dict.ContainsKey("Freight") ? Convert.ToDouble(dict["Freight"]) : 0;
            newRow["ShipCity"] = dict.ContainsKey("ShipCity") ? dict["ShipCity"].ToString() : string.Empty;

            ordersTable.Rows.InsertAt(newRow, 0); // Insert at the top
        }

        return Json(value, JsonRequestBehavior.AllowGet);
    }
    // ✅ Update action
    public ActionResult Update(ExpandoObject value)
    {
        if (value != null)
        {
            var dict = (IDictionary<string, object>)value;
            long orderId = dict.ContainsKey("OrderID") ? Convert.ToInt32(dict["OrderID"]) : 0;

            DataRow rowToUpdate = ordersTable.Rows.Cast<DataRow>()
                .FirstOrDefault(row => row.Field<int>("OrderID") == orderId);

            if (rowToUpdate != null)
            {
                rowToUpdate["CustomerID"] = dict.ContainsKey("CustomerID") ? dict["CustomerID"].ToString() : string.Empty;
                rowToUpdate["EmployeeID"] = dict.ContainsKey("EmployeeID") ? Convert.ToInt32(dict["EmployeeID"]) : 0;
                rowToUpdate["Freight"] = dict.ContainsKey("Freight") ? Convert.ToDouble(dict["Freight"]) : 0;
                rowToUpdate["ShipCity"] = dict.ContainsKey("ShipCity") ? dict["ShipCity"].ToString() : string.Empty;
            }
        }

        return Json(value, JsonRequestBehavior.AllowGet);
    }
    // ✅ Delete action
    public ActionResult Delete(int key)
    {
        var rowToDelete = ordersTable.AsEnumerable()
                                .FirstOrDefault(row => row.Field<int>("OrderID") == key);
        if (rowToDelete != null)
        {
            ordersTable.Rows.Remove(rowToDelete);
        }
        return Json(new { Key = key }, JsonRequestBehavior.AllowGet);
    }
}