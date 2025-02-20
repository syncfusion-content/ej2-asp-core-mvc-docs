public void OnGet()
{
    ViewData["employeeData"] = EmployeeDetails.GetAllRecords();
    ViewData["employeePerformanceData"] = EmployeePerformanceDetails.GetAllRecords();
}