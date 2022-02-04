public class HomeController : Controller
{
    List<gameList> game = new List<gameList>();
    public ActionResult Index()
    {
        game.Add(new gameList { Id = "1", Name = "Maria Anders" });
        game.Add(new gameList { Id = "2", Name = "Ana Trujillo" });
        game.Add(new gameList { Id = "3", Name = "Antonio Moreno" });
        game.Add(new gameList { Id = "4", Name = "Thomas Hardy" });
        game.Add(new gameList { Id = "5", Name = "Chiristina Berglund" });
        game.Add(new gameList { Id = "6", Name = "Hanna Moos" });
        ViewBag.value = "Maria Anders";
        ViewBag.model = new { dataSource = game, fields = new { text = "Name" }, Placeholder = "Select a customer" };
        return View();
    }
    public class gameList
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}