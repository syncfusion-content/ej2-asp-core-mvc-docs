using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
    public string parentId { get; set; }
    public int indent { get; set; }
}

public ActionResult Children()
{
        BlocksData.Add(new BlockModel
        {
                id = "security-callout",
                blockType = "Callout",
                properties = new {
                children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                id = "security-title",
                                parentId = "security-callout",
                                blockType = "Heading",
                                properties = new { level = 3 },
                                content = new List<object>()
                                {
                                        new
                                        {
                                                contentType = "Text",
                                                content = "Security Notice"
                                        }
                                }
                        }
                }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-warning",
                parentId = "security-callout",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                id = "paragraph1-content",
                                contentType = "Text",
                                content = "Always validate user input before processing to prevent security vulnerabilities."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-tips",
                parentId = "security-callout",
                blockType = "Paragraph",
                indent = 1,
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Use HTTPS for all data transmission"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-tips-2",
                parentId = "security-callout",
                blockType = "Paragraph",
                indent = 1,
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Implement proper authentication mechanisms"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-tips-3",
                parentId = "security-callout",
                blockType = "Paragraph",
                indent = 1,
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Regularly update dependencies and libraries"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}