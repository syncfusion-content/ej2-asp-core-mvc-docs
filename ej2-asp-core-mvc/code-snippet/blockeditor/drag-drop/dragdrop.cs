public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult DragDrop()
{
        BlocksData.Add(new BlockModel() {
                blockType = "Heading",
                properties = new { level = 1},
                content = new List<object>()
                {
                        new{
                        contentType = "Text",
                        content = "Drag and Drop Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "Try rearranging blocks by dragging the handle that appears when hovering over them. You can drag a single block or select multiple blocks to drag them together."
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                blockType = "BulletList",
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "Drag and drop is enabled by default"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                blockType = "NumberedList",
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "You can select multiple blocks and drag them together"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                blockType = "NumberedList",
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "Try dragging this block to rearrange the content"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}
