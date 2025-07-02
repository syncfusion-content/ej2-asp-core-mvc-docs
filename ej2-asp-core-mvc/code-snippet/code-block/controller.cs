public class HomeController : Controller
{

    public ActionResult Index()
    {
            ViewBag.items = new[] { "Undo", "Redo", "|", "CodeBlock", "|", "Bold", "Italic", "Underline", "StrikeThrough", "InlineCode", "|", "CreateLink", "Image", "CreateTable", "Blockquote", "|", "BulletFormatList", "NumberFormatList", "|", "Formats", "Alignments", "|", "Outdent", "Indent", "|",
                        "FontColor", "BackgroundColor", "FontName", "FontSize", "|", "LowerCase", "UpperCase", "|", "EmojiPicker", "|", "SourceCode" };
            ViewBag.languages = new[] { 
                new {label= "HTML", language= "html"},
                new {label= "JavaScript", language= "javascript"},
                new {label= "CSS", language= "css"},
                new {label= "Plain Text", language= "plaintext"}};
        return View();
    }
}
