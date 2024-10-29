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
                expanded = true
            });
            listdata.Add(new
            {
                id = 2,
                pid = 1,
                name = "New South Wales",

            });
            listdata.Add(new
            {
                id = 3,
                pid = 1,
                name = "Victoria"
            });

            listdata.Add(new
            {
                id = 4,
                pid = 1,
                name = "South Australia"
            });
            listdata.Add(new
            {
                id = 6,
                pid = 1,
                name = "Western Australia",

            });
            listdata.Add(new
            {
                id = 7,
                name = "Brazil",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 8,
                pid = 7,
                name = "Paraná"
            });
            listdata.Add(new
            {
                id = 9,
                pid = 7,
                name = "Ceará"
            });
            listdata.Add(new
            {
                id = 10,
                pid = 7,
                name = "Acre"
            });
            listdata.Add(new
            {
                id = 11,
                name = "China",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 12,
                pid = 11,
                name = "Guangzhou"
            });
            listdata.Add(new
            {
                id = 13,
                pid = 11,
                name = "Shanghai"
            });
            listdata.Add(new
            {
                id = 14,
                pid = 11,
                name = "Beijing"
            });
            listdata.Add(new
            {
                id = 15,
                pid = 11,
                name = "Shantou"
            });
            listdata.Add(new
            {
                id = 16,
                name = "France",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 17,
                pid = 16,
                name = "Pays de la Loire"
            });
            listdata.Add(new
            {
                id = 18,
                pid = 16,
                name = "Aquitaine"

            });
            listdata.Add(new
            {
                id = 19,
                pid = 16,
                name = "Brittany"

            });
            listdata.Add(new
            {
                id = 20,
                pid = 16,
                name = "Lorraine"
            });
            listdata.Add(new
            {
                id = 21,
                name = "India",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 22,
                pid = 21,
                name = "Assam"

            });
            listdata.Add(new
            {
                id = 23,
                pid = 21,
                name = "Bihar"
            });
            listdata.Add(new
            {
                id = 24,
                pid = 21,
                name = "Tamil Nadu"
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
