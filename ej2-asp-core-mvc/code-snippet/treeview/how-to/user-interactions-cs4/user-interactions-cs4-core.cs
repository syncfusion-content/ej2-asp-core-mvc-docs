public IActionResult NodeEdit()
        {
            List<object> treedata = new List<object>();
            treedata.Add(new
            {
                id = 1,
                name = "Discover Music",
                hasChild = true,
                expanded = true,
                value ="10"
            });
            treedata.Add(new
            {
                id = 2,
                pid = 1,
                name = "Hot Singles",
                value ="10"
            });
            treedata.Add(new
            {
                id = 3,
                pid = 1,
                name = "Rising Artists",
                value ="10"
            });

            treedata.Add(new
            {
                id = 4,
                pid = 1,
                name = "Live Music",
                value ="10"
            });
            treedata.Add(new
            {
                id = 5,
                hasChild = true,
                name = "Sales and Events",
                value ="10"
            });
            treedata.Add(new
            {
                id = 6,
               pid=5,
                name = "100 Albums - $5 Each",
                value ="10"
            });
            treedata.Add(new
            {
                id = 7,
                pid = 5,
                name = "Hip-Hop and R&B Sale",
                value ="10"
            });
            treedata.Add(new
            {
                id = 8,
                pid = 5,
                name = "CD Deals",
                value ="10"
            });
            treedata.Add(new
            {
                id = 10,
                hasChild = true,
                name = "Categories",
                value ="10"
            });
            treedata.Add(new
            {
                id = 11,
                pid=10,
                name = "Bestselling Albums",
                value ="10"
               
            });
            treedata.Add(new
            {
                id = 12,
                pid = 10,
                name = "New Releases",
                value ="10"
            });
            treedata.Add(new
            {
                id = 13,
                pid = 10,
                name = "Bestselling Songs",
                value ="10"
            });
            treedata.Add(new
            {
                id = 14,
                hasChild = true,
                name = "MP3 Albums",
                value ="10"
            });
            treedata.Add(new
            {
                id = 15,
                pid = 14,
                name = "Rock",
                value ="10"

            });
            treedata.Add(new
            {
                id = 16,
                name = "Gospel",
                pid = 14,
                value ="10"

            });
            treedata.Add(new
            {
                id = 17,
                pid = 14,
                name = "Latin Music"
                value ="10"
            });
            treedata.Add(new
            {
                id = 18,
                pid = 14,
                name = "Jazz"
                value ="10"
            });
            treedata.Add(new
            {
                id = 19,
                hasChild = true,
                name = "More in Music"
                value ="10"
            });
            treedata.Add(new
            {
                id = 20,
                pid = 19,
                name = "Music Trade-In",
                value ="10"
            });
            treedata.Add(new
            {
                id = 21,
                name = "Redeem a Gift Card",
                pid = 19,
                value ="10"
            });
            treedata.Add(new
            {
                id = 22,
                pid = 19,
                name = "Band T-Shirts",
                value ="10"

            });
          
            ViewBag.dataSource = treedata;
            return View();
        }
