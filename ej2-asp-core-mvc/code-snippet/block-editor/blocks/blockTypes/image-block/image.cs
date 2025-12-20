using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Image()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "Image",
                properties = new
                {
                        src = "https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png",
                        altText = "Sample image"
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "You can customize images further by configuring properties like allowedTypes for file upload restrictions, saveFormat for storage preferences, and cssClass for custom styling."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}