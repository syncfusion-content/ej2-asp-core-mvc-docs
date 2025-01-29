public class GroupingModel : PageModel
{
    public List<object>? DataSource { get; set; }

    public void OnGet()
    {
        DataSource = new List<object>
        {
            new { text = "Audi A4", id = "9bdb", category = "Audi" },
            new { text = "Audi A5", id = "4589", category = "Audi" },
            new { text = "BMW 501", id = "f849", category = "BMW" },
            new { text = "BMW 502", id = "7aff", category = "BMW" }
        };
    }
}