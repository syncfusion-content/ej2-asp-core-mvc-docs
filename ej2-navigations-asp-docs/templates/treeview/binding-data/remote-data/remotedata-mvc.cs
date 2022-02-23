using Syncfusion.EJ2.Navigations;

public IActionResult RemoteData()
        {
            TreeViewFieldsSettings parentData = new TreeViewFieldsSettings();
            TreeViewFieldsSettings childData = new TreeViewFieldsSettings();
            object data = new DataManager
            {
                Url = "https://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc",
                Adaptor = "ODataAdaptor",
                CrossDomain = true
            };
            // Parent data mapping
            parentData.Query = "new ej.data.Query().from('Employees').select('EmployeeID,FirstName,Title').take(5)";
            parentData.Id = "EmployeeID";
            parentData.Text = "FirstName";
            parentData.HasChildren = "EmployeeID";
            parentData.Child = childData;
            parentData.DataSource = data;
            // Child data mapping  
            childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
            childData.Id = "OrderID";
            childData.Text = "ShipName";
            childData.ParentID = "EmployeeID";
            childData.DataSource = data;
            ViewBag.remoteFields = parentData;
            return View();
            return View();
        }
