public class ListViewController : Controller
{
    public IActionResult List()
    {
        List<object> listData = new List<object>();
        listData.Add(new
        {
            text = "Jenifer",
            contact = "(206) 555-985774",
            id = "1",
            avatar = "J",
            pic = "pic01"
        });
        listData.Add(new
        {
            text = "Amenda",
            contact = "(206) 555-3412",
            id = "2",
            avatar = "A",
            pic = ""
        });
        listData.Add(new
        {
            text = "Isabella",
            contact = "(206) 555-8122",
            id = "4",
            avatar = "",
            pic = "pic02"
        });
        listData.Add(new
        {
            text = "William ",
            contact = "(206) 555-9482",
            id = "5",
            avatar = "W",
            pic = ""
        });
        listData.Add(new
        {
            text = "Jacob",
            contact = "(71) 555-4848",
            id = "6",
            avatar = "",
            pic = "pic04"
        });
        listData.Add(new
        {
            text = "Matthew",
            contact = "(71) 555-7773",
            id = "7",
            avatar = "M",
            pic = ""
        });
        listData.Add(new
        {
            text = "Oliver",
            contact = "(71) 555-5598",
            id = "8",
            avatar = "",
            pic = "pic03"
        });
        listData.Add(new
        {
            text = "Charlotte",
            contact = "(206) 555-1189",
            id = "9",
            avatar = "C",
            pic = ""
        });
        ViewBag.listData = listData;
        return View();
    }
}