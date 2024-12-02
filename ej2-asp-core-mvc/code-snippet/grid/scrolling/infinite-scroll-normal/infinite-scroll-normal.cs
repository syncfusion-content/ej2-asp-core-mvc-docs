public IActionResult Index()
{
    ViewBag.dataSource = GenerateData(5000);
    return View();
}

private List<object> GenerateData(int count)
{
    var names = new[] { "TOM", "Hawk", "Jon", "Chandler", "Monica", "Rachel", "Phoebe", "Gunther", "Ross", "Geller", "Joey", "Bing", "Tribbiani", "Janice", "Bong", "Perk", "Green", "Ken", "AdAMS" };
    var hours = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var designation = new[] { "Manager", "Engineer 1", "Engineer 2", "Developer", "Tester" };
    var status = new[] { "Completed", "Open", "In Progress", "Review", "Testing" };
    var random = new Random();
    var data = new List<object>();
    for (int i = 0; i < count; i++)
    {
        data.Add(new
        {
            TaskID = i + 1,
            Engineer = names[random.Next(names.Length)],
            Designation = designation[random.Next(designation.Length)],
            Estimation = hours[random.Next(hours.Length)],
            Status = status[random.Next(status.Length)]
        });
    }
    return data;
}