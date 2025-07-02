using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult UndoRedo()
{
        BlocksData.Add(new Block() {
                id = "block-1",
                type = "Heading1",
                content = new List<object>()
                {
                        new{
                                type = "Text",
                                content = "Undo/Redo Demo"
                        }
                }
        });
        BlocksData.Add(new Block() {
                id = "block-2",
                type = "Paragraph",
                content = new List<object>()
                {
                        new {
                                type = "Text",
                                content = "Try adding new blocks or modifying content below:"
                        }
                }
        });
        BlocksData.Add(new Block()
        {
                id = "block-3",
                type = "Paragraph",
                content = new List<object>()
                {
                        new {
                                type = "Text",
                                content = "1. Undo stack set to maximum 40 actions\n2. Press Ctrl+Z to undo\n3. Press Ctrl+Y to redo\n4. Actions include text edits, block moves, additions, deletions"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}