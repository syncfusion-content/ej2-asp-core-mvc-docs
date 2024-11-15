public IActionResult Index()
{
    var Order = OrderDetails.GetAllRecords();
    ViewBag.DataSource = Order;
  ViewBag.stringOperatorsData = new string[] {
    "startsWith",
    "endsWith",
    "contains",
    "isnotempty",
    "isempty",
    "isnotnull",
    "isnull",
    "notEqual",
    "equal",
    "doesnotcontain",
    "doesnotendwith",
    "doesnotstartwith",
};
  ViewBag.numericOperatorsData = new string[]  {
    "equal",
    "notEqual",
    "greaterThan",
    "greaterThanOrEqual",
    "lessThan",
    "lessThanOrEqual",
    "isnull",
    "isnotnull",
};
    return View();
}