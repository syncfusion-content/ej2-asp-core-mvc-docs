using Syncfusion.EJ2.Navigations;

{ 
    ......
    public ActionResult Template()
    {
        List<TreeviewTemplate> localData = new List<TreeviewTemplate>();
        localData.Add(new TreeviewTemplate { Id = 1, Name = "Steven Buchanan", HasChild = true, Expanded = true, Image = "10", Job = "CEO" });
        localData.Add(new TreeviewTemplate { Id = 2, PId = 1, Name = "Laura Callahan", Count = "4", Image = "2", Job = "Product Manager", HasChild = true });
        localData.Add(new TreeviewTemplate { Id = 3, PId = 2, Name = "Andrew Fuller", Image = "7", Job = "Team Lead", HasChild = true });
        localData.Add(new TreeviewTemplate { Id = 4, PId = 3, Name = "Anne Dodsworth", Count = "6", Image = "1", Job = "Developer" });
        localData.Add(new TreeviewTemplate { Id = 5, PId = 1, Name = "Nancy Davolio", HasChild = true, Image = "4", Job = "Product Manager" });
        localData.Add(new TreeviewTemplate { Id = 6, PId = 5, Name = "Michael Suyama", Count = "20", Image = "9", Job = "Team Lead", HasChild = true });
        localData.Add(new TreeviewTemplate { Id = 7, PId = 6, Name = "Robert King", Count = "5", Image = "8", Job = "Developer" });
        localData.Add(new TreeviewTemplate { Id = 8, PId = 7, Name = "Margaret Peacock", Image = "6", Job = "Developer" });
        localData.Add(new TreeviewTemplate { Id = 9, PId = 1, Name = "Janet Leverling", Image = "3", Job = "HR" });
        ViewBag.data= localData;
        return View("~/Views/TreeView/Template/Template.cshtml");
    }
}
public class TreeviewTemplate
{
    public string Name { get; set; }
    public string Count { get; set; }
    public int Id { get; set; }
    public int PId { get; set; }
    public bool HasChild { get; set; }
    public bool Expanded { get; set; }
    public bool Selected { get; set; }
    public string Image { get; set; }
    public string Job { get; set; }
}