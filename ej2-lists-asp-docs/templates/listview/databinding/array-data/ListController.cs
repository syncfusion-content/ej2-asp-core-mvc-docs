public class ListViewController : Controller
{
    public IActionResult List()
    {
        List<object> listdata = new List<object>();
        listdata.Add(new
        {
            Name = "Display",
            id = "list-01"

        }); listdata.Add(new
        {
            Name = "Notification",
            id = "list-02"

        }); listdata.Add(new
        {
            Name = "Sound",
            id = "list-03"

        }); listdata.Add(new
        {
            Name = "Apps",
            id = "list-04"

        }); listdata.Add(new
        {
            Name = "Storage",
            id = "list-05"

        }); listdata.Add(new
        {
            Name = "Battery",
            id = "list-06"
        });

        ViewBag.dataSource = listdata;
        return View();
    }
}