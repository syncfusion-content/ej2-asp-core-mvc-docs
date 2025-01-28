public class SidebarWithListviewModel : PageModel
{
    public List<object>? DataSource { get; set; }
    public void OnGet()
    {
        DataSource = new List<object>
    {
        new { text = "Home", id = "list-01" },
        new { text = "Offers", id = "list-02" },
        new { text = "Support", id = "list-03" },
        new { text = "Logout", id = "list-04" }
    };
    }
}