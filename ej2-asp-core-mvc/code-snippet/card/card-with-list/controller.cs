public ActionResult Index()
{
    List<object> listdata = new List<object>();
    listdata.Add(new { todoList = "Pay Bills" });
    listdata.Add(new { todoList = "Call Chris" });
    listdata.Add(new { todoList = "Meet Andrew" });
    listdata.Add(new { todoList = "Visit Manager" });
    listdata.Add(new { todoList = "Customer Meeting" });
    ViewBag.dataSource = listdata;
    return View();
}