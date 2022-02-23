public class TreeviewTemplate
        {
            public string name { get; set; }
            public string count { get; set; }
            public int id { get; set; }
            public int pid { get; set; }
            public bool HasChild { get; set; }
            public bool Expanded { get; set; }
            public bool Selected { get; set; }
            public string Image { get; set; }
            public string Job { get; set; }
            public List<TreeviewTemplate> getTreeviewTemplate()
            {
                List<TreeviewTemplate> localData = new List<TreeviewTemplate>();
                localData.Add(new TreeviewTemplate { id = 1, name = "Steven Buchanan", HasChild = true, Expanded=true, Image = "10", Job= "CEO" });
                localData.Add(new TreeviewTemplate { id = 2, pid = 1, name = "Laura Callahan", count = "4", Image = "2", Job= "Product Manager", HasChild = true });
                localData.Add(new TreeviewTemplate { id = 3, pid = 2, name = "Andrew Fuller", Image = "7", Job= "Team Lead", HasChild= true });
                localData.Add(new TreeviewTemplate { id = 4, pid = 3, name = "Anne Dodsworth", count = "6", Image = "1", Job= "Developer" });
                localData.Add(new TreeviewTemplate { id = 5, pid= 1, name = "Nancy Davolio", HasChild = true, Image = "4", Job= "Product Manager" });
                localData.Add(new TreeviewTemplate { id = 6, pid = 5, name = "Michael Suyama", count = "20", Image = "9", Job= "Team Lead", HasChild = true });
                localData.Add(new TreeviewTemplate { id = 7, pid = 6, name = "Robert King", count = "5", Image = "8", Job= "Developer" });
                localData.Add(new TreeviewTemplate { id = 8, pid = 7, name = "Margaret Peacock", Image = "6" , Job= "Developer" });
                localData.Add(new TreeviewTemplate { id = 9, pid = 1, name = "Janet Leverling", Image = "3", Job= "HR" });
                return localData;
            }
        }