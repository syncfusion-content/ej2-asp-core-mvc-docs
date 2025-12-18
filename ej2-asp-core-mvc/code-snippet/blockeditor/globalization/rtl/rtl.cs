using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Rtl()
{
        BlocksData.Add(new BlockModel() {
                id = "block-1",
                blockType = "Heading",
                properties = new { level = 1},
                content = new List<object>()
                {
                        new{
                                contentType = "Text",
                                content = "Sample Heading"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                id = "block-2",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "This is a sample paragraph block."
                        }
                }
        });
        BlocksData.Add(new BlockModel()
        {
                id = "block-3",
                blockType = "Paragraph"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}