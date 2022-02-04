public ActionResult Index()
{
    ViewBag.datasource = GetEmployeeEventData();
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Day },
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month }
    };
    ViewBag.view = viewOption;
    return View();
}

public List<EmployeeEventData> GetEmployeeEventData()
{
    List<EmployeeEventData> employeeEventData = new List<EmployeeEventData>();
    employeeEventData.Add(new EmployeeEventData
    { Id = 1,
        Subject = "Project Workflow Analysis",
        StartTime = new DateTime(2018, 2, 14, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 14, 11, 0, 0),
        CategoryColor = "#1aaa55"
    });
    employeeEventData.Add(new EmployeeEventData
    {
        Id = 2,
        Subject = "Project Requirement Planning",
        StartTime = new DateTime(2018, 2, 15, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 15, 11, 0, 0),
        CategoryColor = "#357cd2"
    });
    employeeEventData.Add(new EmployeeEventData
    {
        Id = 3,
        Subject = "Quality Analysis",
        StartTime = new DateTime(2018, 2, 16, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 16, 11, 0, 0),
        CategoryColor = "#7fa900"
    });
    return employeeEventData;
}

public class EmployeeEventData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string CategoryColor { get; set; }
}