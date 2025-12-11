using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public class CodeBlockSettingsModel
{
    public string defaultLanguage { get; set; }
    public List<object> languages { get; set; }
}

public ActionResult Code()
{
        BlocksData.Add(new BlockModel()
        {
                blockType = "Code",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "function greeting() {\n  console.log(\"Hello, world!\");\n}"
                        }
                }
        });
        var codeBlockSettings = new CodeBlockSettingsModel
        {
                defaultLanguage = "javascript",
                languages = new List<object>
                {
                        new
                        {
                                label = "JavaScript",
                                language = "javascript"
                        },
                        new
                        {
                                label = "TypeScript",
                                language = "typescript"
                        },
                        new
                        {
                                label = "HTML",
                                language = "html"
                        },
                        new
                        {
                                label = "CSS",
                                language = "css"
                        }
                }
        };
        ViewBag.BlocksData = BlocksData;
        ViewBag.CodeBlocksData = codeBlockSettings;
        return View();
}