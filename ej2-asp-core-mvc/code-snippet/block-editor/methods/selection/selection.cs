using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Selection()
{
        BlocksData.Add(new BlockModel
        {
                id = "heading-block",
                blockType = "Heading",
                properties = new { level = 1},
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Welcome to Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "paragraph-1",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                id = "paragraph1-content",
                                contentType = "Text",
                                content = "This is the first paragraph with some sample text content for selection demonstration."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "paragraph-2",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This is the second paragraph that can be used for various selection operations."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "list-block",
                blockType = "BulletList",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "First list item"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}