using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Divider()
{
        BlocksData.Add(new BlockModel()
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "This section discusses the features of the Block Editor."
                        }
                }
        });
        BlocksData.Add(new BlockModel()
        {
                blockType = "Divider",
        });
        BlocksData.Add(new BlockModel()
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "This section covers implementation details and usage examples."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}