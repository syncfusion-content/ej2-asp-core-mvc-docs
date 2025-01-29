 public class HeaderTemplateModel : PageModel
 {
     public List<FruitModel>? FruitsData { get; set; }
     public string? HeaderTemplate { get; set; }

     public void OnGet()
     {
         FruitsData = new List<FruitModel>
     {
         new FruitModel { Text = "Date", Id = "1"},
         new FruitModel { Text = "Fig", Id = "2" },
         new FruitModel { Text = "Apple", Id = "3" },
         new FruitModel { Text = "Apricot", Id = "4" },
         new FruitModel { Text = "Grape", Id = "5" },
         new FruitModel { Text = "Strawberry", Id = "6" },
         new FruitModel { Text = "Pineapple", Id = "7" },
         new FruitModel { Text = "Melon", Id = "8" },
         new FruitModel { Text = "Lemon", Id = "9" },
         new FruitModel { Text = "Cherry", Id = "10" }
     };

         HeaderTemplate = @"<div class='headerContainer'><span class='fruitHeader'>Fruits</span>
         <button id='search'></button><button id='add'></button><button id='sort'></button></div>";
     }
 }

 public class FruitModel
 {
     public string? Text { get; set; }
     public string? Id { get; set; }
 }