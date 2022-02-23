public ActionResult Index()
{
    List<OwnerResources> owners = new List<OwnerResources>();
    owners.Add(new OwnerResources { OwnerText = "Nancy", Id = 1, OwnerColor = "#ffaa00" });
    owners.Add(new OwnerResources { OwnerText = "Steven", Id = 2, OwnerColor = "#f8a398" });
    owners.Add(new OwnerResources { OwnerText = "Michael", Id = 3, OwnerColor = "#7499e1" });
    ViewBag.Owners = owners;
    string[] resources = new string[] { "Owners" };
    ViewBag.Resources = resources;
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Month },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineMonth },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Agenda }
    };
    ViewBag.view = viewOption;
    return View();
}

public class OwnerResources
{
    public string OwnerText { set; get; }
    public int Id { set; get; }
    public string OwnerColor { set; get; }
}