public ActionResult Index()
{
    List<CalendarRes> ownerCollections = new List<CalendarRes>()
        {
            new CalendarRes { OwnerText = 'Margaret', OwnerId = 1, Color = '#ea7a57' },
            new CalendarRes { OwnerText = 'Robert', OwnerId = 2, Color = '#df5286' },
            new CalendarRes { OwnerText = 'Laura', OwnerId = 3, Color = '#865fcf' }
        };
    ViewBag.Calendars = ownerCollections;

    ViewBag.datasource = GetScheduleData();
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month }
    };
    ViewBag.view = viewOption;
     List<ScheduleToolbarItem> toolbarItems = new List<ScheduleToolbarItem>()
        {
            new ScheduleToolbarItem { Name = ToolbarName.Previous, Align = ItemAlign.Left },
            new ScheduleToolbarItem { Name = ToolbarName.Next, Align = ItemAlign.Left },
            new ScheduleToolbarItem { Name = ToolbarName.DateRangeText, Align = ItemAlign.Left },
            new ScheduleToolbarItem { Template = "#dropelement", Type = ItemType.Input, Align = ItemAlign.Center },
            new ScheduleToolbarItem { Name = ToolbarName.Today, Align = ItemAlign.Right },
        };
        ViewBag.toolbarItems = toolbarItems;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData{
        Id: 1,
        Subject: 'Paris',
        StartTime: new Date(2023, 9, 29, 10, 0),
        EndTime: new Date(2023, 9, 29, 11, 30),
        IsAllDay: false,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 2,
        Subject: 'Meeting - 1',
        StartTime: new Date(2023, 9, 30, 10, 0),
        EndTime: new Date(2023, 9, 30, 12, 30),
        IsAllDay: false,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 3,
        Subject: 'Meeting - 2',
        StartTime: new Date(2023, 9, 30, 11, 0),
        EndTime: new Date(2023, 9, 30, 14, 30),
        IsAllDay: false,
        OwnerId: 3
    }), 
    appData.Add(new AppointmentData{
        Id: 4,
        StartTime: new Date(2023, 9, 31),
        EndTime: new Date(2023, 10, 1),
        IsAllDay: true,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 5,
        Subject: 'Conference - 2',
        StartTime: new Date(2023, 9, 31, 22, 0),
        EndTime: new Date(2023, 10, 1, 0, 0),
        IsAllDay: false,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 6,
        Subject: 'Conference - 3',
        StartTime: new Date(2023, 10, 1, 9, 30),
        EndTime: new Date(2023, 10, 1, 11, 45),
        IsAllDay: false,
        OwnerId: 3
    }), 
    appData.Add(new AppointmentData{
        Id: 7,
        Subject: 'Conference - 4',
        StartTime: new Date(2023, 10, 1, 10, 30),
        EndTime: new Date(2023, 10, 1, 12, 45),
        IsAllDay: false,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 8,
        Subject: 'Travelling',
        StartTime: new Date(2023, 10, 1, 11, 30),
        EndTime: new Date(2023, 10, 1, 13, 45),
        IsAllDay: false,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 9,
        Subject: 'Vacation',
        StartTime: new Date(2023, 10, 2, 10, 0),
        EndTime: new Date(2023, 10, 2, 12, 30),
        IsAllDay: false,
        OwnerId: 3
    }), 
    appData.Add(new AppointmentData{
        Id: 10,
        Subject: 'Conference',
        StartTime: new Date(2023, 10, 2, 15, 30),
        EndTime: new Date(2023, 10, 2, 18, 45),
        IsAllDay: false,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 11,
        Subject: 'Vacation',
        StartTime: new Date(2023, 10, 3, 10, 15),
        EndTime: new Date(2023, 10, 3, 14, 45),
        IsAllDay: false,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 12,
        Subject: 'Conference',
        StartTime: new Date(2023, 10, 4, 9, 30),
        EndTime: new Date(2023, 10, 5, 5, 45),
        IsAllDay: false,
        OwnerId: 3
    }), 
    appData.Add(new AppointmentData{
        Id: 13,
        StartTime: new Date(2023, 10, 5, 10, 0),
        EndTime: new Date(2023, 10, 5, 11, 30),
        IsAllDay: false,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 14,
        Subject: 'Same Time',
        StartTime: new Date(2023, 10, 5, 10, 0),
        EndTime: new Date(2023, 10, 5, 11, 30),
        IsAllDay: false,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 15,
        Subject: 'Same Time',
        StartTime: new Date(2023, 10, 5, 10, 0),
        EndTime: new Date(2023, 10, 5, 11, 30),
        IsAllDay: false,
        OwnerId: 3
    }, 
    appData.Add(new AppointmentData{
        Id: 16,
        Subject: 'Same Time',
        StartTime: new Date(2023, 10, 5, 10, 0),
        EndTime: new Date(2023, 10, 5, 11, 30),
        IsAllDay: false,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 17,
        Subject: 'Same Time',
        StartTime: new Date(2023, 10, 5, 10, 0),
        EndTime: new Date(2023, 10, 5, 11, 30),
        IsAllDay: false,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 18,
        Subject: 'Same Time',
        StartTime: new Date(2023, 10, 5, 10, 0),
        EndTime: new Date(2023, 10, 5, 11, 30),
        IsAllDay: false,
        OwnerId: 3
    }, 
    appData.Add(new AppointmentData{
        Id: 19,
        Subject: 'Meeting - 1',
        StartTime: new Date(2023, 10, 6),
        EndTime: new Date(2023, 10, 7),
        IsAllDay: true,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData
        Id: 20,
        Subject: 'Meeting - 2',
        StartTime: new Date(2023, 10, 6, 11, 0),
        EndTime: new Date(2023, 10, 6, 14, 30),
        IsAllDay: false,
        OwnerId: 3
    }), 
    appData.Add(new AppointmentData{
        Id: 21,
        Subject: 'Conference - 1',
        StartTime: new Date(2023, 10, 7, 22, 0),
        EndTime: new Date(2023, 10, 8, 20, 0),
        IsAllDay: true,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 22,
        Subject: 'Conference - 2',
        StartTime: new Date(2023, 10, 7, 22, 0),
        EndTime: new Date(2023, 10, 14, 23, 0),
        IsAllDay: false,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 23,
        Subject: 'Conference - 3',
        StartTime: new Date(2023, 10, 8, 9, 30),
        EndTime: new Date(2023, 10, 9, 11, 45),
        IsAllDay: true,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 24,
        Subject: 'Conference - 3 - A',
        StartTime: new Date(2023, 10, 8, 9, 30),
        EndTime: new Date(2023, 10, 8, 10, 0),
        IsAllDay: true,
        OwnerId: 3
    }), 
    appData.Add(new AppointmentData{
        Id: 25,
        Subject: 'Conference - 3 - B',
        StartTime: new Date(2023, 10, 8, 10, 0),
        EndTime: new Date(2023, 10, 8, 10, 30),
        IsAllDay: false,
        OwnerId: 1
    }), 
    appData.Add(new AppointmentData{
        Id: 26,
        Subject: 'Conference - 4',
        StartTime: new Date(2023, 10, 8, 10, 30),
        EndTime: new Date(2023, 10, 8, 12, 45),
        IsAllDay: false,
        OwnerId: 2
    }), 
    appData.Add(new AppointmentData{
        Id: 27,
        Subject: 'Travelling',
        StartTime: new Date(2023, 10, 8, 11, 30),
        EndTime: new Date(2023, 10, 8, 13, 45),
        IsAllDay: false,
        OwnerId: 3
    })
    return appData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}
