using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Table()
{
        BlockData.Add(new BlockModel
        {
        blockType = "Paragraph",
        content = new List<object>
        {
        new { contentType = "Text", content = "You can resize table columns by dragging column borders and can do multi-row column selection and perform deletion via popup." }
        }
        });
        BlockData.Add(new BlockModel
        {
        blockType = "Table",
        properties = new
        {
                columns = new List<object>
                {
                new { id = "col1", headerText="Column 1" },
                new { id = "col2", headerText="Column 2" },
                new { id = "col3", headerText="Column 3" }
                }
                ,
                rows = new List<object>
                {
                new
                {
                        cells = new List<object>
                        {
                                new { columnId = "col1",  blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 1" } } } } },
                                new { columnId = "col2", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 2" } } } } },
                                new { columnId = "col3", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 3" } } } } },
                                new { columnId = "col4", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 4" } } } } }
                        }
                },
                new
                {
                        cells = new List<object>
                        {
                                new { columnId = "col1", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 5" } } } } },
                                new { columnId = "col2", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 6" } } } } },
                                new { columnId = "col3", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 7" } } } } },
                                new { columnId = "col4", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 8" } } } } }
                        }
                },
                new
                {
                        cells = new List<object>
                        {
                                new { columnId = "col1", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 9" } } } } },
                                new { columnId = "col2", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 10" } } } } },
                                new { columnId = "col3", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 11" } } } } },
                                new { columnId = "col4", blocks = new List<BlockModel> { new BlockModel { blockType = "Paragraph", content = new List<object> { new { contentType = "Text", content = "Cell 12" } } } } }
                        }
                }
                }
        }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}
