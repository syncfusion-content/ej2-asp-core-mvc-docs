public class VirtualizationModel : PageModel
{
    public List<ListItemModel>? ListData { get; set; }

    public void OnGet()
    {
        ListData = new List<ListItemModel>();
        var initialData = new List<ListItemModel>
    {
        new ListItemModel { Text = "Nancy", Id = "0" },
        new ListItemModel { Text = "Andrew", Id = "1" },
        new ListItemModel { Text = "Janet", Id = "2" },
        new ListItemModel { Text = "Margaret", Id = "3" },
        new ListItemModel { Text = "Steven", Id = "4" },
        new ListItemModel { Text = "Laura", Id = "5" },
        new ListItemModel { Text = "Robert", Id = "6" },
        new ListItemModel { Text = "Michael", Id = "7" },
        new ListItemModel { Text = "Albert", Id = "8" },
        new ListItemModel { Text = "Nolan", Id = "9" }
    };

        ListData.AddRange(initialData);

        var random = new Random();
        for (int i = 10; i < 1000; i++)
        {
            int index = random.Next(0, 10);
            ListData.Add(new ListItemModel
            {
                Text = initialData[index].Text,
                Id = i.ToString()
            });
        }
    }
}

public class ListItemModel
{
    public string? Text { get; set; }
    public string? Id { get; set; }
}