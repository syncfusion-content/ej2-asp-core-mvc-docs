public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Undo", "Redo", "|", "CodeBlock", "|", "Bold", "Italic", "Underline", "StrikeThrough", "InlineCode", "|", "CreateLink", "Image", "CreateTable", "Blockquote", "|", "BulletFormatList", "NumberFormatList", "|", "Formats", "Alignments", "|", "Outdent", "Indent", "|",
                        "FontColor", "BackgroundColor", "FontName", "FontSize", "|", "LowerCase", "UpperCase", "|", "EmojiPicker", "|", "SourceCode" };
        ViewBag.languages = new[] { {label: "HTML", language: "html"},
                    {label: "JavaScript", language: "javascript"},
                    {label: "CSS", language: "css"},
                    {label: "Plain Text", language: "plaintext"}};
        return View();
    }
}