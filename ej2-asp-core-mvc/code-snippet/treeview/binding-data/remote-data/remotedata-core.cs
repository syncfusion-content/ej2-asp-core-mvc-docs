public IActionResult RemoteData()
        {
            TreeViewFieldsSettings childData = new TreeViewFieldsSettings();
            childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
            childData.Id = "OrderID";
            childData.Text = "ShipName";
            childData.ParentID = "EmployeeID";
            childData.DataSource = new DataManager
            {
                Url = "https://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc",
                Adaptor = "ODataAdaptor",
                CrossDomain = true
            };
            ViewBag.child = childData;
            return View();
        }
