public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    return View();
}

public List<GroupData> GetPivotData()
{
    List<GroupData> groupData = new List<GroupData>();
    groupData.Add(new GroupData
    {
        Id = 1001,
        TimeLine = "1/1/2015",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Hydro-electric",
        PowUnits = 46,
        ProCost = 43,
        Year = "FY 2015"
    });
    groupData.Add(new GroupData
    {
        Id = 1002,
        TimeLine = "2/1/2015",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Geo-thermal",
        PowUnits = 30,
        ProCost = 29,
        Year = "FY 2016"
    });
    groupData.Add(new GroupData
    {
        Id = 1003,
        TimeLine = "3/1/2015",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Solar",
        PowUnits = 125,
        ProCost = 96,
        Year = "FY 2015"
    });
    groupData.Add(new GroupData
    {
        Id = 1004,
        TimeLine = "4/1/2015",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Wind",
        PowUnits = 215,
        ProCost = 123
    });
    groupData.Add(new GroupData
    {
        Id = 1005,
        TimeLine = "5/1/2015",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Wind",
        PowUnits = 263,
        ProCost = 125
    });
    groupData.Add(new GroupData
    {
        Id = 1006,
        TimeLine = "6/1/2015",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Hydro-electric",
        PowUnits = 61,
        ProCost = 50
    });
    groupData.Add(new GroupData
    {
        Id = 1007,
        TimeLine = "7/1/2015",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Geo-thermal",
        PowUnits = 20,
        ProCost = 31
    });
    groupData.Add(new GroupData
    {
        Id = 1008,
        TimeLine = "8/1/2015",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Solar",
        PowUnits = 133,
        ProCost = 110
    });
    groupData.Add(new GroupData
    {
        Id = 1053,
        TimeLine = "3/1/2016",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Wind",
        PowUnits = 201,
        ProCost = 105
    });
    groupData.Add(new GroupData
    {
        Id = 1054,
        TimeLine = "4/1/2016",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Hydro-electric",
        PowUnits = 55,
        ProCost = 46
    });
    groupData.Add(new GroupData
    {
        Id = 1055,
        TimeLine = "5/1/2016",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Geo-thermal",
        PowUnits = 20,
        ProCost = 37
    });
    groupData.Add(new GroupData
    {
        Id = 1056,
        TimeLine = "6/1/2016",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Solar",
        PowUnits = 122,
        ProCost = 118
    });
    groupData.Add(new GroupData
    {
        Id = 1057,
        TimeLine = "7/1/2016",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Hydro-electric",
        PowUnits = 69,
        ProCost = 54
    });
    groupData.Add(new GroupData
    {
        Id = 1094,
        TimeLine = "6/1/2016",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Hydro-electric",
        PowUnits = 40,
        ProCost = 52
    });
    groupData.Add(new GroupData
    {
        Id = 1095,
        TimeLine = "7/1/2016",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Geo-thermal",
        PowUnits = 19,
        ProCost = 40
    });
    groupData.Add(new GroupData
    {
        Id = 1096,
        TimeLine = "8/1/2016",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Solar",
        PowUnits = 127,
        ProCost = 91
    });
    groupData.Add(new GroupData
    {
        Id = 1097,
        TimeLine = "9/1/2016",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Hydro-electric",
        PowUnits = 70,
        ProCost = 66
    });
    groupData.Add(new GroupData
    {
        Id = 1098,
        TimeLine = "10/1/2016",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Geo-thermal",
        PowUnits = 36,
        ProCost = 21
    });
    groupData.Add(new GroupData
    {
        Id = 1099,
        TimeLine = "11/1/2016",
        Sector = "Public Sector",
        EnerType = "Free Energy",
        EneSource = "Solar",
        PowUnits = 144,
        ProCost = 85
    });
    groupData.Add(new GroupData
    {
        Id = 1100,
        TimeLine = "12/1/2016",
        Sector = "Private Sector",
        EnerType = "Free Energy",
        EneSource = "Wind",
        PowUnits = 212,
        ProCost = 130
    });
    return View(groupData);
}

public class GroupData
{
    public int Id { get; set; }
    public string TimeLine { get; set; }
    public string Sector { get; set; }
    public string EnerType { get; set; }
    public string EneSource { get; set; }
    public int PowUnits { get; set; }
    public int ProCost { get; set; }
    public string Year { get; set; }
    public string Quarter { get; set; }
    public string HalfYear { get; set; }
}