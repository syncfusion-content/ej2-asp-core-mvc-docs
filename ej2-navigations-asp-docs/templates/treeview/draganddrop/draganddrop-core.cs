public IActionResult DragDrop()
        {
            List<object> treedata = new List<object>();
            treedata.Add(new
            {
                id = 1,
                name = "ASP.NET MVC Team",
                hasChild = true,
                expanded = true
            });
            treedata.Add(new
            {
                id = 2,
                pid = 1,
                name = "Smith",
             is_selected=true

            });
            treedata.Add(new
            {
                id = 3,
                pid = 1,
                name = "Johnson",
                is_selected = true
            });

            treedata.Add(new
            {
                id = 4,
                pid = 1,
                name = "Anderson"
            });
            treedata.Add(new
            {
                id = 6,
                hasChild = true,
                name = "Windows Team",

            });
            treedata.Add(new
            {
                id = 7,
                pid=6,
                name="Clark"
                
            });
            treedata.Add(new
            {
                id = 8,
                pid = 6,
                name = "Wright"
            });
            treedata.Add(new
            {
                id = 9,
                pid = 6,
                name = "Lopez"
            });
            treedata.Add(new
            {
                id = 10,
                hasChild = true,
                name = "Web Team"
            });
            treedata.Add(new
            {
                id = 11,
                pid=10,
                name = "Joshua",
               
            });
            treedata.Add(new
            {
                id = 12,
                pid = 10,
                name = "Matthew"
            });
            treedata.Add(new
            {
                id = 13,
                pid = 10,
                name = "David"
            });
            treedata.Add(new
            {
                id = 14,
                hasChild = true,
                name = "Build Team"
            });
            treedata.Add(new
            {
                id = 15,
                pid = 14,
                name = "Ryan"

            });
            treedata.Add(new
            {
                id = 16,
                pid=14,
                name = "Justin",
              
            });
            treedata.Add(new
            {
                id = 17,
                pid = 14,
                name = "Robert"

            });
            treedata.Add(new
            {
                id = 18,
                hasChild=true,
                name = "WPF Team"

            });
            treedata.Add(new
            {
                id = 19,
                pid = 18,
                name = "Brown"

            });
            treedata.Add(new
            {
                id = 20,
                pid = 18,
                name = "Johnson"
            });
            treedata.Add(new
            {
                id = 21,
                pid = 18,
                name = "Miller"
            });

            ViewBag.dataSource = treedata;
            return View();
        }
