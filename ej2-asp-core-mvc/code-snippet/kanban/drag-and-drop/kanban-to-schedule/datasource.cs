public class KanbanDataModels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Tags { get; set; }
        public Double Estimate { get; set; }
        public string Assignee { get; set; }
        public int RankId { get; set; }
        public string Color { get; set; }

        public List<KanbanDataModels> KanbanTasks()
        {
            List<KanbanDataModels> TaskDetais = new List<KanbanDataModels>();
            TaskDetais.Add(new KanbanDataModels { Id = 1, Title = "Task  - 29001", Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Type = "Story", Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Nancy Davloio", RankId = 1, Color = "#8b447a" });
            TaskDetais.Add(new KanbanDataModels { Id = 2, Title = "Task  - 29002", Status = "InProgress", Summary = "Improve application performance", Type = "Improvement", Priority = "Normal", Tags = "Improvement", Estimate = 6, Assignee = "Andrew Fuller", RankId = 1, Color = "#7d7297" });
            TaskDetais.Add(new KanbanDataModels { Id = 3, Title = "Task  - 29003", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements.", Type = "Others", Priority = "Critical", Tags = "Meeting", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 2, Color = "#27AE60" });
            TaskDetais.Add(new KanbanDataModels { Id = 4, Title = "Task  - 29004", Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Type = "Bug", Priority = "Release Breaker", Tags = "IE", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 2, Color = "#cc0000" });
            TaskDetais.Add(new KanbanDataModels { Id = 5, Title = "Task  - 29005", Status = "Review", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1, Color = "#cc0000" });
            return TaskDetais;
        }
    }
    public class ScheduleData
    {
        public List<HospitalData> GetHospitalData()
        {
            List<HospitalData> hospitalData = new List<HospitalData>();
            hospitalData.Add(new HospitalData
            {
                Id = 10,
                Name = "David",
                StartTime = new DateTime(2018, 7, 1, 9, 0, 0),
                EndTime = new DateTime(2018, 7, 1, 10, 0, 0),
                Description = "Health Checkup",
                DepartmentID = 1,
                ConsultantID = 1,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 11,
                Name = "John",
                StartTime = new DateTime(2018, 7, 1, 10, 30, 0),
                EndTime = new DateTime(2018, 7, 1, 11, 30, 0),
                Description = "Tooth Erosion",
                DepartmentID = 2,
                ConsultantID = 2,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 12,
                Name = "Peter",
                StartTime = new DateTime(2018, 7, 1, 12, 0, 0),
                EndTime = new DateTime(2018, 7, 1, 13, 0, 0),
                Description = "Eye and Spectacles Checkup",
                DepartmentID = 1,
                ConsultantID = 3,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 13,
                Name = "Starc",
                StartTime = new DateTime(2018, 7, 1, 14, 0, 0),
                EndTime = new DateTime(2018, 7, 1, 15, 0, 0),
                Description = "Toothaches",
                DepartmentID = 2,
                ConsultantID = 4,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 14,
                Name = "James",
                StartTime = new DateTime(2018, 7, 1, 10, 0, 0),
                EndTime = new DateTime(2018, 7, 1, 11, 0, 0),
                Description = "Surgery Appointment",
                DepartmentID = 1,
                ConsultantID = 5,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 15,
                Name = "Jercy",
                StartTime = new DateTime(2018, 7, 1, 9, 30, 0),
                EndTime = new DateTime(2018, 7, 1, 10, 30, 0),
                Description = "Tooth Sensitivity",
                DepartmentID = 2,
                ConsultantID = 6,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 16,
                Name = "Albert",
                StartTime = new DateTime(2018, 7, 2, 10, 0, 0),
                EndTime = new DateTime(2018, 7, 2, 11, 30, 0),
                Description = "Skin care treatment",
                DepartmentID = 1,
                ConsultantID = 7,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 17,
                Name = "Louis",
                StartTime = new DateTime(2018, 7, 2, 12, 30, 0),
                EndTime = new DateTime(2018, 7, 2, 13, 30, 0),
                Description = "General Checkup",
                DepartmentID = 1,
                ConsultantID = 9,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 18,
                Name = "Williams",
                StartTime = new DateTime(2018, 7, 2, 12, 0, 0),
                EndTime = new DateTime(2018, 7, 2, 14, 0, 0),
                Description = "Mouth Sores",
                DepartmentID = 2,
                ConsultantID = 10,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 19,
                Name = "David",
                StartTime = new DateTime(2018, 7, 2, 16, 30, 0),
                EndTime = new DateTime(2018, 7, 2, 18, 45, 0),
                Description = "Eye checkup and Treatment",
                DepartmentID = 1,
                ConsultantID = 1,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 20,
                Name = "John",
                StartTime = new DateTime(2018, 7, 2, 19, 30, 0),
                EndTime = new DateTime(2018, 7, 2, 21, 45, 0),
                Description = "Tooth Decay",
                DepartmentID = 2,
                ConsultantID = 2,
                DepartmentName = "DENTAL"
            });
            return hospitalData;
        }
    }
    public class HospitalData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public int DepartmentID { get; set; }
        public int ConsultantID { get; set; }
        public string DepartmentName { get; set; }
    }
    public class ResourceDataSourceModel
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
        public int groupId { set; get; }
    }
    public class ConsultantDataSourceModel
    {
        public string text { set; get; }
        public int id { set; get; }
        public int groupId { set; get; }
        public string color { set; get; }
        public string designation { set; get; }
    }