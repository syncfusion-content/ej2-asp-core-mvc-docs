public IActionResult CheckBox()
        {
            List<object> treedata = new List<object>();
            treedata.Add(new
            {
                Id = 1,
                Name = "Vue",
                HasChild = true,
                Expanded = true,
                NavigateUrl: 'https://ej2.syncfusion.com/vue/documentation/treeview/getting-started'
            });
            treedata.Add(new
            {
                Id = 2,
                Pid = 1,
                Name = "JavaScript",
                NavigateUrl: 'https://ej2.syncfusion.com/javascript/documentation/treeview/es5-getting-started'

            });
            treedata.Add(new
            {
                Id = 3,
                Pid = 1,
                Name = "ASP.NET Core",
                NavigateUrl: 'https://ej2.syncfusion.com/aspnetcore/documentation/treeview/getting-started',
            });

            treedata.Add(new
            {
                Id = 4,
                Name: 'Angular',
                HasChild: true,
                NavigateUrl: 'https://ej2.syncfusion.com/angular/documentation/treeview/getting-started',
            });
            treedata.Add(new
            {
                Id: 5,
                Pid: 4,
                Name: 'Blazor',
                NavigateUrl: 'https://blazor.syncfusion.com/documentation/treeview/getting-started-webapp',

            });
            treedata.Add(new
            {
                Id: 6,
                Pid: 4,
                Name: 'React',
                NavigateUrl:'https://ej2.syncfusion.com/react/documentation/treeview/getting-started',
            });
            ViewBag.dataSource = treedata;
            return View();
        }
