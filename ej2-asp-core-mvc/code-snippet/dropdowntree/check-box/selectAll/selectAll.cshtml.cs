public class SelectAllModel : PageModel
{
    public List<object>? TreeData { get; set; }
    public void OnGet()
    {
        TreeData = new List<object>();
        TreeData.Add(new { id = 1, name = "Discover Music", hasChild = true, expanded = true });
        TreeData.Add(new { id = 2, pid = 1, name = "Hot Singles" });
        TreeData.Add(new { id = 3, pid = 1, name = "Rising Artists" });
        TreeData.Add(new { id = 4, pid = 1, name = "Live Music" });
        TreeData.Add(new { id = 5, name = "Sales and Events", hasChild = true });
        TreeData.Add(new { id = 6, pid = 5, name = "100 Albums - $5 Each" });
        TreeData.Add(new { id = 7, pid = 5, name = "Hip-Hop and R&B Sale" });
        TreeData.Add(new { id = 8, pid = 5, name = "CD Deals" });
        TreeData.Add(new { id = 10, name = "Categories", hasChild = true });
        TreeData.Add(new { id = 11, pid = 10, name = "Bestselling Albums" });
        TreeData.Add(new { id = 12, pid = 10, name = "New Releases" });
        TreeData.Add(new { id = 13, pid = 10, name = "Bestselling Songs" });
        TreeData.Add(new { id = 14, name = "MP3 Albums", hasChild = true });
        TreeData.Add(new { id = 15, pid = 14, name = "Rock" });
        TreeData.Add(new { id = 16, pid = 14, name = "Gospel" });
        TreeData.Add(new { id = 17, pid = 14, name = "Latin Music" });
        TreeData.Add(new { id = 18, pid = 14, name = "Jazz" });
        TreeData.Add(new { id = 19, name = "More in Music", hasChild = true });
        TreeData.Add(new { id = 20, pid = 19, name = "Music Trade-In" });
        TreeData.Add(new { id = 21, pid = 19, name = "Redeem a Gift Card" });
        TreeData.Add(new { id = 22, pid = 19, name = "Band T-Shirts" });
    }
}
