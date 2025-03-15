public IActionResult Index()
{
  return View();
}

public IActionResult GetEmployeeRecords()
{
  IEnumerable employeeData = EmployeeView.GetAllRecords();
  return Json(employeeData);
}

public IActionResult GetOrderRecords([FromBody] DataManagerRequest request)
{
  IEnumerable orderData = OrdersDetails.GetAllRecords();
  DataOperations dataOperations = new DataOperations();
  if (request.Sorted != null && request.Sorted.Count > 0)
  {
    string sortColumn = request.Sorted[0].Name;
    string sortDirection = request.Sorted[0].Direction;
    if (sortColumn == "EmployeeID")
    {
      orderData = GetSortedOrdersByEmployee(sortDirection);
    }
    else
    {
      orderData = dataOperations.PerformSorting(orderData, request.Sorted);
    }
  }
  int totalRecords = orderData.Cast<OrdersDetails>().Count();
  if (request.Skip != 0)
  {
    orderData = dataOperations.PerformSkip(orderData, request.Skip);
  }
  if (request.Take != 0)
  {
    orderData = dataOperations.PerformTake(orderData, request.Take);
  }
  return request.RequiresCounts ? Json(new { result = orderData, count = totalRecords }) : Json(orderData);
}

private List<OrdersDetails> GetSortedOrdersByEmployee(string sortDirection)
{
  var employees = EmployeeView.GetAllRecords();
  List<EmployeeView> sortedEmployees = (sortDirection == "ascending")
    ? employees.OrderBy(e => e.FirstName).ToList()
    : employees.OrderByDescending(e => e.FirstName).ToList();

  List<OrdersDetails> sortedOrders = new List<OrdersDetails>();
  foreach (var employee in sortedEmployees)
  {
    var employeeOrders = OrdersDetails.GetAllRecords().Where(o => o.EmployeeID == employee.EmployeeID).ToList();
    sortedOrders.AddRange(employeeOrders);
  }
  return sortedOrders;
}
