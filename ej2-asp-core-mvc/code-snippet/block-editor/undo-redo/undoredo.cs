using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult UndoRedo()
{
        BlocksData.Add(new BlockModel() {
                id = "block-1",
                blockType = "Heading",
                properties = new { level = 1},
                content = new List<object>()
                {
                        new{
                                contentType = "Text",
                                content = "Undo/Redo Demo"
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
                                content = "Try adding new blocks or modifying content below:"
                        }
                }
        });
        BlocksData.Add(new BlockModel()
        {
                id = "block-3",
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "1. Undo stack set to maximum 40 actions\n2. Press Ctrl+Z to undo\n3. Press Ctrl+Y to redo\n4. Actions include text edits, block moves, additions, deletions"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}