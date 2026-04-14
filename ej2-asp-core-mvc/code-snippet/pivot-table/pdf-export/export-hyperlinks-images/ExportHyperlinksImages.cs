public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.filterMembers = new string[] { "Sales Representative" };
    return View();
}

public class Employee
{
    public int EmployeeID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string EmailID { get; set; }
    public string Title { get; set; }
    public string Department { get; set; }
    public string Office { get; set; }
    public double Salary { get; set; }
    public double SalesYTD { get; set; }
    public int OrdersCount { get; set; }
    public string EmployeeImage { get; set; }
}