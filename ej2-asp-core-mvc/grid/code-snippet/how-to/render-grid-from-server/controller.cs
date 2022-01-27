public class HomeController : Controller
    {
        public static List<Orders> order = new List<Orders>();
        public ActionResult Index()
        {
            Syncfusion.EJ2.Grids.Grid gridProp = new Syncfusion.EJ2.Grids.Grid();
            gridProp.AllowPaging = true;
            gridProp.DataSource = order;
            gridProp.EditSettings = new Syncfusion.EJ2.Grids.GridEditSettings() { AllowEditing = true, AllowDeleting = true, AllowAdding = true };
            List<object> col = new List<object>();
            gridProp.Toolbar = new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" };
            col.Add(new { field = "OrderID", isPrimaryKey = true, headerText = "OrderID", width = "120" });
            col.Add(new { field = "CustomerID", headerText = "CustomerID", width = "120" });
            col.Add(new { field = "EmployeeID", headerText = "EmployeeID", width = "120" });
            gridProp.Columns = col;
            return View(gridProp);
        }
    }