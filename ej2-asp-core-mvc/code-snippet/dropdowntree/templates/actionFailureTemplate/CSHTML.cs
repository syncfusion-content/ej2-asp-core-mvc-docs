    public class ActionFailureTemplateModel : PageModel
    {
        public DropDownTreeFields childData = new DropDownTreeFields();
        public void OnGet()
        {
            childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
            childData.Value = "OrderID";
            childData.Text = "ShipName";
            childData.ParentValue = "EmployeeID";
            childData.DataSource = new DataManager
            {
                Url = "http://services.odata.org/V4/Northwind/Northwind.svc",
                Adaptor = "ODataV4Adaptor",
                CrossDomain = true
            };
        }
    }
}