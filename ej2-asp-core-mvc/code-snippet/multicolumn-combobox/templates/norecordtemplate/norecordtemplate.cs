public ActionResult Demo()
{
    var employees = new List<Employee> {};

    ViewBag.EmpData = employees;
    return View(ViewBag.EmpData);
}

public class Employee
{
	public int EmpID { get; set; }
	public string Name { get; set; }
	public string Designation { get; set; }
	public string Country { get; set; }
}