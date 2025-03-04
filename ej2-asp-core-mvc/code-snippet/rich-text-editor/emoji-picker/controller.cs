public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.value = @"<p>An emoji picker in a Rich Text Editor is a tool that allows users to easily add emojis or emoticons to their text.</p>
        <p>Typically, it is a small window or panel that displays a variety of emojis, arranged in different categories, such as smileys, animals, food, and so on. Users can select the desired emoji by clicking on it or by typing its name in a search bar.</p>";
        
        ViewBag.items = new[] { "EmojiPicker"};

        return View();
    }
}