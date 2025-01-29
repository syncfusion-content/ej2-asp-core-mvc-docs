
public class SimpleDataModel : PageModel
{
    public string[]? DataSource { get; set; }
    public void OnGet()
    {
        DataSource = new string[]
        {
            "Artwork",
            "Abstract",
            "Modern Painting",
            "Ceramics",
            "Animation Art",
            "Oil Painting"
        };
    }
}