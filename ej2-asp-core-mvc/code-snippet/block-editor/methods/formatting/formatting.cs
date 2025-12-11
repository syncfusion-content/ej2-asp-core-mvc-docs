using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Formatting()
{
        BlocksData.Add(new BlockModel
        {
                id = "sample-heading",
                blockType = "Heading",
                properties = new { level = 1},
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Formatting Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "sample-paragraph-1",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Select this text and apply different formatting options using the buttons below. You can make text bold or change colors for the text."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "sample-list",
                blockType = "BulletList",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "List item for formatting demonstration"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}