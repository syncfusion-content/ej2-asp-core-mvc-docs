using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        public List<GanttDataSource> DataSource { get; set; } = new();

        public void OnGet()
        {
            DataSource = GetGanttData();
        }

        public static List<GanttDataSource> GetGanttData()
        {
            return new List<GanttDataSource>
            {
                // 1. Project Initiation (Parent)
                new() {
                    TaskID = 1,
                    TaskName = "Project Initiation",
                    Progress = 100,
                    Status = "Completed"
                },
                new() {
                    TaskID = 2,
                    TaskName = "Kickoff Meeting",
                    ParentID = 1,
                    StartDate = new DateTime(2025, 3, 3),
                    Duration = 1,
                    Progress = 100,
                    Status = "Completed"
                },
                new() {
                    TaskID = 3,
                    TaskName = "Requirements Gathering",
                    ParentID = 1,
                    StartDate = new DateTime(2025, 3, 4),
                    Duration = 3,
                    Progress = 100,
                    Status = "Completed"
                },

                // 4. System Design (Parent)
                new() {
                    TaskID = 4,
                    TaskName = "System Design",
                    Progress = 80, // Average of children
                    Status = "In Progress"
                },
                new() {
                    TaskID = 5,
                    TaskName = "Architecture Design",
                    ParentID = 4,
                    StartDate = new DateTime(2025, 3, 7),
                    Duration = 4,
                    Progress = 90,
                    Status = "In Progress"
                },
                new() {
                    TaskID = 6,
                    TaskName = "Database Design",
                    ParentID = 4,
                    StartDate = new DateTime(2025, 3, 12),
                    Duration = 3,
                    Progress = 70,
                    Status = "In Progress"
                },

                // 7. Development Phase (Parent)
                new() {
                    TaskID = 7,
                    TaskName = "Development Phase",
                    Progress = 62, // Average
                    Status = "In Progress"
                },
                new() {
                    TaskID = 8,
                    TaskName = "Backend Development",
                    ParentID = 7,
                    StartDate = new DateTime(2025, 3, 15),
                    Duration = 5,
                    Progress = 70,
                    Status = "In Progress"
                },
                new() {
                    TaskID = 9,
                    TaskName = "Frontend Development",
                    ParentID = 7,
                    StartDate = new DateTime(2025, 3, 20),
                    Duration = 5,
                    Progress = 55,
                    Status = "In Progress"
                },
                new() {
                    TaskID = 10,
                    TaskName = "API Integration",
                    ParentID = 7,
                    StartDate = new DateTime(2025, 3, 25),
                    Duration = 4,
                    Progress = 60,
                    Status = "In Progress"
                },

                // 11. Testing Cycle (Parent)
                new() {
                    TaskID = 11,
                    TaskName = "Testing Cycle",
                    Progress = 60, // Approx average
                    Status = "In Progress"
                },
                new() {
                    TaskID = 12,
                    TaskName = "Test Planning",
                    ParentID = 11,
                    StartDate = new DateTime(2025, 3, 29),
                    Duration = 3,
                    Progress = 90,
                    Status = "In Progress"
                },
                new() {
                    TaskID = 13,
                    TaskName = "Test Execution",
                    ParentID = 11,
                    StartDate = new DateTime(2025, 4, 1),
                    Duration = 4,
                    Progress = 60,
                    Status = "In Progress"
                },
                new() {
                    TaskID = 14,
                    TaskName = "Bug Fixing",
                    ParentID = 11,
                    StartDate = new DateTime(2025, 4, 5),
                    Duration = 4,
                    Progress = 30,
                    Status = "In Progress"
                },

                // 15. Deployment & Go-Live (Parent)
                new() {
                    TaskID = 15,
                    TaskName = "Deployment & Go-Live",
                    Progress = 0,
                    Status = "Not Started"
                },
                new() {
                    TaskID = 16,
                    TaskName = "Final Release",
                    ParentID = 15,
                    StartDate = new DateTime(2025, 4, 9),
                    Duration = 3,
                    Progress = 0,
                    Status = "Not Started"
                } 
            };
        }

    public class GanttDataSource
    {
        public int TaskID { get; set; }
        public string? TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public int? Progress { get; set; }
        public string? Predecessor { get; set; }
        public int? ParentID { get; set; }
        public string? Status { get; set; }
            
        }
    }
}