public IActionResult Index()
{
    var data = GenerateData(5000);
    ViewBag.dataSource = data;
    return View();
}

private List<GridData> GenerateData(int count)
{
    var names = new[] { "TOM", "Hawk", "Jon", "Chandler", "Monica", "Rachel", "Phoebe", "Gunther", "Ross", "Geller", "Joey", "Bing", "Tribbiani", "Janice", "Bong", "Perk", "Green", "Ken", "Adams" };
    var hours = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var designations = new[] { "Manager", "Engineer 1", "Engineer 2", "Developer", "Tester" };
    var statuses = new[] { "Completed", "Open", "In Progress", "Review", "Testing" };

    var result = new List<GridData>();
    var random = new Random();
    for (var i = 0; i < count; i++)
    {
        result.Add(new GridData
           {
                TaskID = i + 1,
                Engineer = names[random.Next(names.Length)],
                Designation = designations[random.Next(designations.Length)],
                Estimation = hours[random.Next(hours.Length)],
                Status = statuses[random.Next(statuses.Length)]
            });
    }
    return result;
}

public class GridData
{
    public int TaskID { get; set; }
    public string Engineer { get; set; }
    public string Designation { get; set; }
    public int Estimation { get; set; }
    public string Status { get; set; }
}