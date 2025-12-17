using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
    public List<BlockModel> children { get; set; }
}

public ActionResult Callout()
{
        BlocksData.Add(new BlockModel() {
                blockType = "Callout",
                properties = new {
                children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                id = "callout-content-1",
                                blockType = "Paragraph",
                                content = new List<object>(){
                                        new{
                                                id = "callout-content-1",
                                                contentType = "Text",
                                                content = "Important information: This is a callout block used to highlight important content."
                                        }
                                }
                        }
                }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}