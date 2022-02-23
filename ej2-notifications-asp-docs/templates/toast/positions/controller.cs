public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.data = new Position().Positions();
        return View();
    }
    public class Position
    {
        public string Value { get; set; }
        public string Id { get; set; }
        public List<Position> Positions()
        {
            List<Position> position = new List<Position>
                {
                    new Position { Id = "topleft", Value = "Top Left" },
                    new Position { Id = "topright", Value = "Top Right" },
                    new Position { Id = "topcenter", Value = "Top Center" },
                    new Position { Id = "topfullwidth", Value = "Top Full Width" },
                    new Position { Id = "bottomleft", Value = "Bottom Left" },
                    new Position { Id = "bottomright", Value = "Bottom Right" },
                    new Position { Id = "bottomcenter", Value = "Bottom Center" },
                    new Position { Id = "bottomfullwidth", Value = "Bottom Full Width" }
                };
            return position;
        }
    }
}