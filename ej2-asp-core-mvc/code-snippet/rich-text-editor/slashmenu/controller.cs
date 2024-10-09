public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.items = new[] {  "Bold", "Italic", "Underline", "StrikeThrough", "SuperScript", "SubScript", "|",
        "FontName", "FontSize", "FontColor", "BackgroundColor", "|",
        "LowerCase", "UpperCase",
        "Formats", "Alignments", "|", "NumberFormatList", "BulletFormatList", "|",
        "Outdent", "Indent", "|",
        "CreateLink", "Image", "Video", "Audio", "CreateTable", "|", "FormatPainter", "ClearFormat", "|", "EmojiPicker", "|",
        "SourceCode", "|", "Undo", "Redo" };
        return View();
        RichTextEditorSlashMenuSettings SlashMenuSettings = new RichTextEditorSlashMenuSettings
        {
        Items = new object[] { "Paragraph", "Heading 1", "Heading 2", "Heading 3", "Heading 4", "OrderedList", "UnorderedList",
                    "CodeBlock", "Blockquote", "Link", "Image", "Video", "Audio", "Table", "Emojipicker",
                    new {
                        text= "Meeting notes",
                        description= "Insert a meeting note template.",
                        iconCss= "e-icons e-description",
                        type= "Custom",
                        command= "MeetingNotes"
                    },
                    new {
                        text= "Signature",
                        description= "Insert a signature template.",
                        iconCss= "e-icons e-signature",
                        type= "Custom",
                        command= "Signature"
                    }               
            }
        }
    }
}