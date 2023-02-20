
public ActionResult Index()
{
    var treeData = TreeGridItems.GetTreeData();
    ViewBag.datasource = treeData;
	var emp = new Data().DataList();
    ViewBag.DropData = emp;
    return View();    
}

 public class Data{
      public string EmployeeName { get; set; }
      public string EmployeeID { get; set; }
      public List<Data> DataList() {
         List<Data> value = new List<Data>();
         value.Add(new Data { EmployeeName = "ANTOR", EmployeeID = "1" });
         value.Add(new Data { EmployeeName = "HANAR", EmployeeID = "2" });
         value.Add(new Data { EmployeeName = "VINCENT", EmployeeID = "3" });
         return value;
     }
 }

