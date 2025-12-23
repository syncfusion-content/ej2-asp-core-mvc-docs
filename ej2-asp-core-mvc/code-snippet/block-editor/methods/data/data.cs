using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Data()
{
        BlocksData.Add(new BlockModel
        {
                id = "title-block",
                blockType = "Heading",
                properties = new { level = 1},
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Document Export Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "intro-paragraph",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This document demonstrates the data export capabilities of the Block Editor. You can export content as JSON or HTML formats."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-heading",
                blockType = "Heading",
                properties = new { level = 2},
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Export Features"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-list",
                blockType = "BulletList",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "JSON export for data processing"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-list-2",
                blockType = "BulletList",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "HTML export for web display"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-list-3",
                blockType = "BulletList",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Print functionality for hard copies"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "code-example",
                blockType = "Code",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "var data = editor.getDataAsJson();\nconsole.log(data);"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}