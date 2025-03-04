public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = @"<p>An emoji picker in a Rich Text Editor is a tool that allows users to easily add emojis or emoticons to their text.</p>
        <p>Typically, it is a small window or panel that displays a variety of emojis, arranged in different categories, such as smileys, animals, food, and so on. Users can select the desired emoji by clicking on it or by typing its name in a search bar.</p>";
        ViewBag.items = new[]
        {
            "EmojiPicker", "ClearFormat", "Bold", "Italic", "Underline", "|",
            "Formats", "Alignments", "OrderedList", "UnorderedList", "|",
            "CreateLink", "Image", "|", "SourceCode", "Undo", "Redo"
        };

        ViewBag.iconsSet = new[]
        {
            new
            {
                name = "Smilies & People",
                code = "1F600",
                iconCss = "e-emoji",
                icons = new[]
                {
                    new { code = "1F600", desc = "Grinning face" },
                    new { code = "1F603", desc = "Grinning face with big eyes" },
                    new { code = "1F604", desc = "Grinning face with smiling eyes" },
                    new { code = "1F606", desc = "Grinning squinting face" },
                    new { code = "1F605", desc = "Grinning face with sweat" },
                    new { code = "1F602", desc = "Face with tears of joy" },
                    new { code = "1F923", desc = "Rolling on the floor laughing" },
                    new { code = "1F60A", desc = "Smiling face with smiling eyes" }
                }
            },
            new {
                name = "Animals & Nature",
                code = "1F435",
                iconCss = "e-animals",
                icons = new[] {
                    new { code = "1F436", desc = "Dog face" },
                    new { code = "1F431", desc = "Cat face" },
                    new { code = "1F42D", desc = "Mouse face" },
                    new { code = "1F439", desc = "Hamster face" },
                    new { code = "1F430", desc = "Rabbit face" },
                    new { code = "1F98A", desc = "Fox face" }
                }
            },
            new {
                name = "Food & Drink",
                code = "1F347",
                iconCss = "e-food-and-drinks",
                icons = new[] {
                    new { code = "1F34E", desc = "Red apple" },
                    new { code = "1F34C", desc = "Banana" },
                    new { code = "1F347", desc = "Grapes" },
                    new { code = "1F353", desc = "Strawberry" },
                    new { code = "1F35E", desc = "Bread" },
                    new { code = "1F950", desc = "Croissant" },
                    new { code = "1F955", desc = "Carrot" },
                    new { code = "1F354", desc = "Hamburger" }
                }
            },
            new {
                name = "Activities",
                code = "1F383",
                iconCss = "e-activities",
                icons = new[] {
                    new { code = "26BD", desc = "Soccer ball" },
                    new { code = "1F3C0", desc = "Basketball" },
                    new { code = "1F3C8", desc = "American football" },
                    new { code = "26BE", desc = "Baseball" },
                    new { code = "1F3BE", desc = "Tennis" },
                    new { code = "1F3D0", desc = "Volleyball" },
                    new { code = "1F3C9", desc = "Rugby football" }
                }
            },
        };
        return View();
    }
}