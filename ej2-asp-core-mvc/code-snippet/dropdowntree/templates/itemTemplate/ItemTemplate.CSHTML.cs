 public class ItemTemplateModel : PageModel
 {
     public List<object>? LocalData { get; set; }
     public string? ItemTemplate { get; set; }

     public void OnGet()
     {
         LocalData = new List<object>
         {
             new { id = 1, name = "Steven Buchanan", hasChild = true, expanded = true, job = "General Manager" },
             new { id = 2, pid = 1, name = "Laura Callahan", job = "Product Manager", hasChild = true },
             new { id = 3, pid = 2, name = "Andrew Fuller", job = "Team Lead", hasChild = true },
             new { id = 4, pid = 3, name = "Anne Dodsworth", job = "Developer" },
             new { id = 5, pid = 3, name = "Lilly", job = "Developer", status = "online" },
             new { id = 6, pid = 1, name = "Nancy Davolio", job = "Product Manager", hasChild = true },
             new { id = 7, pid = 6, name = "Michael Suyama", job = "Team Lead", hasChild = true },
             new { id = 8, pid = 7, name = "Robert King", job = "Developer" },
             new { id = 9, pid = 7, name = "Mary", job = "Developer" },
             new { id = 10, pid = 1, name = "Janet Leverling", job = "HR" }
         };

         ItemTemplate = "<div><span class='ename'>${name} - </span><span class='ejob'>${job}</span></div>";
     }
 }