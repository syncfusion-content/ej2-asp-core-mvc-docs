// GET: HandleEvents
public ActionResult HandleEvents()
{
    List<object> menuItems = new List<object>() {
                new {
                    text = "Events",
                    items = new List<object>() {
                        new { text= "Conferences" },
                        new { text= "Music" },
                        new { text= "Workshops" }
                    }
                },
                new {
                    text = "Movies",
                    items = new List<object>() {
                        new { text= "Now Showing" },
                        new { text= "Coming Soon" }
                    }
                },
                new {
                    text = "Directory",
                    items = new List<object>() {
                        new { text= "Media Gallery" },
                        new { text= "Newsletters" }
                    }
                },
                new {
                    text = "Queries",
                    items = new List<object>() {
                        new { text= "Our Policy" },
                        new { text= "Site Map"},
                        new { text= "24x7 Support"}
                    }
                },
                new { text= "Services" }
            };

    ViewBag.menuItems = menuItems;
    return View();
}