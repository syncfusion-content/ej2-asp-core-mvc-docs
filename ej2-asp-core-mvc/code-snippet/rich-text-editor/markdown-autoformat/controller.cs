public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = @"<h3>Markdown Auto-Format</h3><p>The Markdown Auto-Format feature automatically converts Markdown syntax into clean, semantic HTML within the Rich Text Editor. This capability streamlines content creation by allowing you to write using familiar Markdown patterns while ensuring consistent HTML output.</p><p>When enabled, the editor supports both <b>inline formatting</b> (such as bold and italic) and <b>block-level elements</b> (such as headings and lists). As you type, Markdown syntax is instantly transformed into its corresponding HTML tags, delivering a smooth and efficient editing experience.</p><p>It also supports <b>checklists</b> and <b>to-do lists,</b> allowing you to create interactive task lists using simple Markdown syntax.</p>";
        return View();
    }
}