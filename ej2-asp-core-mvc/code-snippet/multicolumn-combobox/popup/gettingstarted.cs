public ActionResult Demo()
{
    var employees = new List<Employee>
    {
        new Employee { EmpID = 1001, Name = "Andrew Fuller", Designation = "Team Lead", Country = "England" },
        new Employee { EmpID = 1002, Name = "Robert", Designation = "Developer", Country = "USA" },
        new Employee { EmpID = 1003, Name = "Michael", Designation = "HR", Country = "Russia" },
        new Employee { EmpID = 1004, Name = "Steven Buchanan", Designation = "Product Manager", Country = "Ukraine" },
        new Employee { EmpID = 1005, Name = "Margaret Peacock", Designation = "Developer", Country = "Egypt" },
        new Employee { EmpID = 1006, Name = "Janet Leverling", Designation = "Team Lead", Country = "Africa" },
        new Employee { EmpID = 1007, Name = "Alice", Designation = "Product Manager", Country = "Australia" },
        new Employee { EmpID = 1008, Name = "Bob", Designation = "Developer", Country = "India" },
        new Employee { EmpID = 1009, Name = "John", Designation = "Product Manager", Country = "Ireland" },
        new Employee { EmpID = 1010, Name = "Mario Pontes", Designation = "Team Lead", Country = "South Africa" },
        new Employee { EmpID = 1011, Name = "Yang Wang", Designation = "Developer", Country = "Russia" },
        new Employee { EmpID = 1012, Name = "David", Designation = "Product Manager", Country = "Egypt" },
        new Employee { EmpID = 1013, Name = "Antonio Bianchi", Designation = "Team Lead", Country = "USA" },
        new Employee { EmpID = 1014, Name = "Laura", Designation = "Developer", Country = "England" },
        new Employee { EmpID = 1015, Name = "Carlos Hernandez", Designation = "Developer", Country = "Canada" },
        new Employee { EmpID = 1016, Name = "Lily", Designation = "Product Manager", Country = "France" },
        new Employee { EmpID = 1017, Name = "Tom Williams", Designation = "Developer", Country = "Ukraine" },
        new Employee { EmpID = 1018, Name = "Grace", Designation = "Developer", Country = "Australia" },
        new Employee { EmpID = 1019, Name = "Olivia", Designation = "Team Lead", Country = "Ireland" },
        new Employee { EmpID = 1020, Name = "James", Designation = "Developer", Country = "China" }
    };

    ViewBag.EmpData = employees;
    return View(ViewBag.EmpData);
}