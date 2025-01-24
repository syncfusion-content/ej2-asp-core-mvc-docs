public class NoRecordsTemplateModel : PageModel
{
    public List<object>? LocalData { get; set; }

    public void OnGet()
    {
        LocalData = new List<object> { };
    }
}