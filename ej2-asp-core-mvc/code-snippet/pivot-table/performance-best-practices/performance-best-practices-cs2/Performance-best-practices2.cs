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
	TimeLine_Year = "1/1/2015",
	TimeLine_Month = "1/1/2015",
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
	TimeLine_Year = "2/1/2015",
	TimeLine_Month = "2/1/2015",
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
	TimeLine_Year = "3/1/2015",
	TimeLine_Month = "3/1/2015",
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
	TimeLine_Year = "4/1/2015",
	TimeLine_Month = "4/1/2015",
	Sector = "Private Sector",
	EnerType = "Free Energy",
	EneSource = "Wind",
	PowUnits = 215,
	ProCost = 123
});
groupData.Add(new GroupData
{
	Id = 1005,
	TimeLine_Year = "5/1/2015",
	TimeLine_Month = "5/1/2015",
	Sector = "Public Sector",
	EnerType = "Free Energy",
	EneSource = "Wind",
	PowUnits = 263,
	ProCost = 125
});
groupData.Add(new GroupData
{
	Id = 1006,
	TimeLine_Year = "6/1/2015",
	TimeLine_Month = "6/1/2015",
	Sector = "Private Sector",
	EnerType = "Free Energy",
	EneSource = "Hydro-electric",
	PowUnits = 61,
	ProCost = 50
});
groupData.Add(new GroupData
{
	Id = 1007,
	TimeLine_Year = "7/1/2015",
	TimeLine_Month = "7/1/2015",
	Sector = "Public Sector",
	EnerType = "Free Energy",
	EneSource = "Geo-thermal",
	PowUnits = 20,
	ProCost = 31
});
groupData.Add(new GroupData
{
	Id = 1008,
	TimeLine_Year = "8/1/2015",
	TimeLine_Month = "8/1/2015",
	Sector = "Private Sector",
	EnerType = "Free Energy",
	EneSource = "Solar",
	PowUnits = 133,
	ProCost = 110
});
groupData.Add(new GroupData
{
	Id = 1001,
	TimeLine_Year = "3/1/2016",
	TimeLine_Month = "3/1/2016",
	Sector = "Public Sector",
	EnerType = "Free Energy",
	EneSource = "Wind",
	PowUnits = 201,
	ProCost = 105
});
groupData.Add(new GroupData
{
	Id = 1002,
	TimeLine_Year = "4/1/2016",
	TimeLine_Month = "4/1/2016",
	Sector = "Private Sector",
	EnerType = "Free Energy",
	EneSource = "Hydro-electric",
	PowUnits = 55,
	ProCost = 46
});
groupData.Add(new GroupData
{
	Id = 1003,
	TimeLine_Year = "5/1/2016",
	TimeLine_Month = "5/1/2016",
	Sector = "Public Sector",
	EnerType = "Free Energy",
	EneSource = "Geo-thermal",
	PowUnits = 20,
	ProCost = 37
});
groupData.Add(new GroupData
{
	Id = 1004,
	TimeLine_Year = "6/1/2016",
	TimeLine_Month = "6/1/2016",
	Sector = "Private Sector",
	EnerType = "Free Energy",
	EneSource = "Solar",
	PowUnits = 122,
	ProCost = 118
});
groupData.Add(new GroupData
{
	Id = 1005,
	TimeLine_Year = "7/1/2016",
	TimeLine_Month = "7/1/2016",
	Sector = "Public Sector",
	EnerType = "Free Energy",
	EneSource = "Hydro-electric",
	PowUnits = 69,
	ProCost = 54
});
groupData.Add(new GroupData
{
	Id = 1006,
	TimeLine_Year = "6/1/2016",
	TimeLine_Month = "6/1/2016",
	Sector = "Private Sector",
	EnerType = "Free Energy",
	EneSource = "Hydro-electric",
	PowUnits = 40,
	ProCost = 52
});
groupData.Add(new GroupData
{
	Id = 1007,
	TimeLine_Year = "7/1/2016",
	TimeLine_Month = "7/1/2016",
	Sector = "Public Sector",
	EnerType = "Free Energy",
	EneSource = "Geo-thermal",
	PowUnits = 19,
	ProCost = 40
});
groupData.Add(new GroupData
{
	Id = 1008,
	TimeLine_Year = "8/1/2016",
	TimeLine_Month = "8/1/2016",
	Sector = "Private Sector",
	EnerType = "Free Energy",
	EneSource = "Solar",
	PowUnits = 127,
	ProCost = 91
});
return View(groupData);

}

public class GroupData
{
	public int Id { get; set; }
	public string TimeLine_Year { get; set; }
	public string TimeLine_Month { get; set; }
	public string Sector { get; set; }
	public string EnerType { get; set; }
	public string EneSource { get; set; }
	public int PowUnits { get; set; }
	public int ProCost { get; set; }
	public string Year { get; set; }
	public string Quarter { get; set; }
	public string HalfYear { get; set; }
}