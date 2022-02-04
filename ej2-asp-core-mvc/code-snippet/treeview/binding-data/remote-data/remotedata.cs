public IActionResult RemoteData()
        {
            TreeViewFieldsSettings childData = new TreeViewFieldsSettings();
            childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
            childData.Id = "OrderID";
            childData.Text = "ShipName";
            childData.ParentID = "EmployeeID";
            childData.DataSource = new DataManager
            {
                Url = "https://services.odata.org/V4/Northwind/Northwind.svc",
                Adaptor = "ODataV4Adaptor",
                CrossDomain = true
            };
            ViewBag.child = childData;
            return View();
        }
