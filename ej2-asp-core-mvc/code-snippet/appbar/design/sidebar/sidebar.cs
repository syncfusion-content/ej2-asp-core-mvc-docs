public ActionResult Index()
{
    Dictionary<string, object> htmlAttribute = new Dictionary<string, object>()
    {   {"class", "sidebar-treeview" } };
    ViewBag.HtmlAttribute = htmlAttribute;
    List<TreeDatas> treedata = new List<TreeDatas>();
    treedata.Add(new TreeDatas { nodeId = "01", nodeText = "Installation" });
    treedata.Add(new TreeDatas { nodeId = "02", nodeText = "Deployment" });
    treedata.Add(new TreeDatas { nodeId = "03", nodeText = "Quick Start" });
    treedata.Add(new TreeDatas { nodeId = "04", nodeText = "Components", hasChild = true });
    treedata.Add(new TreeDatas { nodeId = "04-01", nodeText = "Calendar", pid = "04" });
    treedata.Add(new TreeDatas { nodeId = "04-02", nodeText = "DatePicker", pid = "04" });
    treedata.Add(new TreeDatas { nodeId = "04-03", nodeText = "DateTimePicker", pid = "04" });
    treedata.Add(new TreeDatas { nodeId = "04-04", nodeText = "DateRangePicker", pid = "04" });
    treedata.Add(new TreeDatas { nodeId = "04-05", nodeText = "TimePicker", pid = "04" });
    treedata.Add(new TreeDatas { nodeId = "04-06", nodeText = "SideBar", pid = "04" });
    ViewBag.TreeData = treedata;
    return View();
}

public class TreeDatas
{
    public string nodeId { get; set; }
    public string nodeText { get; set; }
    public bool hasChild { get; set; }
    public string pid { get; set; }
}