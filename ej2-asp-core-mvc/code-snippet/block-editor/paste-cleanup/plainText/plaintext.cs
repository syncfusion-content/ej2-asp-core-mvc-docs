using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult PlainText()
{
        BlocksData.Add(new BlockModel()
        {
                id = "demo-block",
                blockType = "Paragraph"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}