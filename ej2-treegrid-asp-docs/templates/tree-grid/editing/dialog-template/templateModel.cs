    public class TreeData
    {
        public TreeData() { }

        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Duration { get; set; }

        public int Progress { get; set; }
        public string Priority { get; set; }
        public bool Approved { get; set; }

        public DateTime FilterStartDate { get; set; }
        public DateTime FilterEndDate { get; set; }

        public List<TreeData> Children { get; set; }

        public int? ParentId { get; set; }
    }