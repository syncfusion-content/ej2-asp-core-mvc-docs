public ActionResult Index()
{
    List<DoctorResources> doctors = new List<DoctorResources>();
    doctors.Add(new DoctorResources { text = "Nancy", id = 1, color = "#ea7a57" });
    doctors.Add(new DoctorResources { text = "Alice", id = 2, color = "#7fa900" });
    doctors.Add(new DoctorResources { text = "Robson", id = 3, color = "#7499e1" });
    ViewBag.Doctors = doctors;
    string[] resources = new string[] { "Doctors" };
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

public class DoctorResources
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
}