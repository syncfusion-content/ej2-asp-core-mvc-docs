public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Appearance()
{
        BlocksData.Add(new BlockModel
        {
                id = "title-block",
                blockType = "Heading",
                properties = new { level = 1 },
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Appearance Configuration Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "intro-block",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                id = "paragraph1-content",
                                contentType = "Text",
                                content = "This demo showcases different appearance configurations including readonly mode and a custom CSS theme."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-heading",
                blockType = "Heading",
                properties = new { level = 2 },
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Configured Custom Theme"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "theme-list-1",
                blockType = "BulletList",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Gradient background with modern styling"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "readonly-info",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Use the readonly toggle to switch between editable and read-only modes. In readonly mode, you can view content but cannot make changes."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}