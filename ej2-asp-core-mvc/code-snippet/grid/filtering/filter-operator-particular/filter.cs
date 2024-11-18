public IActionResult Index()
{
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
  ViewBag.DataSource = OrderDetails.GetAllRecords();
  return View();
}