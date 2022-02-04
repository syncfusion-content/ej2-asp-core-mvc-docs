public ActionResult Index()
{
    ViewBag.datasource = GetWebinarData();
    ViewBag.template = "<div class='template-wrap' style='background:${SecondaryColor}'><div class='subject' style='background:${PrimaryColor}'>${Subject}</div><div class='time' style='background:${PrimaryColor}'>Time: ${getTimeString(data.StartTime)} - ${getTimeString(data.EndTime)}</div><div class='image'><img src = '../../Content/schedule/images/${ImageName}.svg' alt='${ImageName}'/></div><div class='description'>${Description}</div><div class='footer' style='background:${PrimaryColor}'></div></div>";
    return View();
}

public List<WebinarData> GetWebinarData()
{
    List<WebinarData> webinarData = new List<WebinarData>();
    webinarData.Add(new WebinarData
    {
        Id = 1,
        Subject = "Environment Day",
        Tags = "Eco day, Forest conserving, Earth & its resources",
        Description = "A day that creates awareness to promote the healthy planet and reduce the air pollution crisis on nature earth.",
        StartTime = new DateTime(2018, 2, 12, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 12, 14, 0, 0),
        ImageName = "environment-day",
        PrimaryColor = "#1aaa55",
        SecondaryColor = "#47bb76"
    });
    webinarData.Add(new WebinarData
    {
        Id = 2,
        Subject = "Health Day",
        Tags = "Reduce mental stress, Follow good food habits",
        Description = "A day that raises awareness on different health issues. It marks the anniversary of the foundation of WHO.",
        StartTime = new DateTime(2018, 2, 13, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 13, 14, 0, 0),
        ImageName = "health-day",
        PrimaryColor = "#357cd2",
        SecondaryColor = "#5d96db"
    });
    webinarData.Add(new WebinarData
    {
        Id = 3,
        Subject = "Cancer Day",
        Tags = "Life threatening cancer effects, Palliative care",
        Description = "A day that raises awareness on cancer and its preventive measures. Early detection saves life.",
        StartTime = new DateTime(2018, 2, 14, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 14, 14, 0, 0),
        ImageName = "cancer-day",
        PrimaryColor = "#7fa900",
        SecondaryColor = "#a4c932"
    });
    webinarData.Add(new WebinarData
    {
        Id = 4,
        Subject = "Happiness Day",
        Tags = "Stress-free, Smile, Resolve frustration and bring happiness",
        Description = "A general idea is to promote happiness and smile around the world.",
        StartTime = new DateTime(2018, 2, 15, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 15, 14, 0, 0),
        ImageName = "happiness-day",
        PrimaryColor = "#ea7a57",
        SecondaryColor = "#ee9478"
    });
    webinarData.Add(new WebinarData
    {
        Id = 5,
        Subject = "Tourism Day",
        Tags = "Diverse cultural heritage, strengthen peace",
        Description = "A day that raises awareness on the role of tourism and its effect on social and economic values.",
        StartTime = new DateTime(2018, 2, 16, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 16, 14, 0, 0),
        ImageName = "tourism-day",
        PrimaryColor = "#00bdae",
        SecondaryColor = "#32cabe"
    });
    return webinarData;
}

public class WebinarData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Tags { get; set; }
    public string Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string ImageName { get; set; }
    public string PrimaryColor { get; set; }
    public string SecondaryColor { get; set; }
}