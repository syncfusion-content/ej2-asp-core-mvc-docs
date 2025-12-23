using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Quote()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>
                {
                new { contentType = "Text", content = "You can customize the table further by configuring properties like width, enableHeader to show a header row, enableRowNumbers to display row indices, and readOnly to prevent edits." }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Table",
                properties = new
                {
                rows = new List<object>
                {
                        new
                        {
                        cells = new List<object>
                        {
                                new { blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 1" } } } } },
                                new { blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 2" } } } } }
                        }
                        },
                        new
                        {
                        cells = new List<object>
                        {
                                new { blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 3" } } } } },
                                new { blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 4" } } } } }
                        }
                        }
                }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}