public ActionResult Demo()
{
    var employees = new List<Employee>{ };
    ViewBag.EmpData = employees;
    return View(ViewBag.EmpData);
}

public class Employee
{
	public int ContactName { get; set; }
	public string CustomerID { get; set; }
}