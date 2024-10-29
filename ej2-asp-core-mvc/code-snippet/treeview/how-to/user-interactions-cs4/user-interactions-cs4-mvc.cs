using Syncfusion.EJ2.Navigations;

public IActionResult NodeEdit()
        {
             TreeViewFieldsSettings Listdata = new TreeViewFieldsSettings();
            List<object> listdata = new List<object>();
            listdata.Add(new
            {
                id = 1,
                name = "Australia",
                hasChild = true,
                expanded = true,
                value ="10"
            });
            listdata.Add(new
            {
                id = 2,
                pid = 1,
                name = "New South Wales",
                value ="10"
            });
            listdata.Add(new
            {
                id = 3,
                pid = 1,
                name = "Victoria",
                value ="10"
            });

            listdata.Add(new
            {
                id = 4,
                pid = 1,
                name = "South Australia",
                value ="10"
            });
            listdata.Add(new
            {
                id = 6,
                pid = 1,
                name = "Western Australia",
                value ="10"

            });
            listdata.Add(new
            {
                id = 7,
                name = "Brazil",
                hasChild = true,
                value ="10"
            });
            listdata.Add(new
            {
                id = 8,
                pid = 7,
                name = "Paraná",
                value ="10"
            });
            listdata.Add(new
            {
                id = 9,
                pid = 7,
                name = "Ceará",
                value ="10"
            });
            listdata.Add(new
            {
                id = 10,
                pid = 7,
                name = "Acre",
                value ="10"
            });
            listdata.Add(new
            {
                id = 11,
                name = "China",
                hasChild = true,
                value ="10"
            });
            listdata.Add(new
            {
                id = 12,
                pid = 11,
                name = "Guangzhou",
                value ="10"
            });
            listdata.Add(new
            {
                id = 13,
                pid = 11,
                name = "Shanghai",
                value ="10"
            });
            listdata.Add(new
            {
                id = 14,
                pid = 11,
                name = "Beijing",
                value ="10"
            });
            listdata.Add(new
            {
                id = 15,
                pid = 11,
                name = "Shantou",
                value ="10"
            });
            listdata.Add(new
            {
                id = 16,
                name = "France",
                hasChild = true,
                value ="10"
            });
            listdata.Add(new
            {
                id = 17,
                pid = 16,
                name = "Pays de la Loire",
                value ="10"
            });
            listdata.Add(new
            {
                id = 18,
                pid = 16,
                name = "Aquitaine",
                value ="10"

            });
            listdata.Add(new
            {
                id = 19,
                pid = 16,
                name = "Brittany",
                value ="10"

            });
            listdata.Add(new
            {
                id = 20,
                pid = 16,
                name = "Lorraine",
                value ="10"
            });
            listdata.Add(new
            {
                id = 21,
                name = "India",
                hasChild = true,
                value ="10"
            });
            listdata.Add(new
            {
                id = 22,
                pid = 21,
                name = "Assam",
                value ="10"

            });
            listdata.Add(new
            {
                id = 23,
                pid = 21,
                name = "Bihar",
                value ="10"
            });
            listdata.Add(new
            {
                id = 24,
                pid = 21,
                name = "Tamil Nadu",
                value ="10"
            });
            Listdata.DataSource = listdata;
            Listdata.Expanded = "expanded";
            Listdata.Id = "id";
            Listdata.ParentID = "pid";
            Listdata.Text = "name";
            Listdata.HasChildren = "hasChild";
            ViewBag.TreeViewFields = Listdata;
            return View();
        }
