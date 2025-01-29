 public class JsonDataModel : PageModel
 {
     public List<object>? DataSource { get; set; }
     public void OnGet()
     {
         DataSource = new List<object>
         {
             new { Name = "Display", id = "list-01" },
             new { Name = "Notification", id = "list-02" },
             new { Name = "Sound", id = "list-03" },
             new { Name = "Apps", id = "list-04" },
             new { Name = "Storage", id = "list-05" },
             new { Name = "Battery", id = "list-06" }
         };
     }
 }