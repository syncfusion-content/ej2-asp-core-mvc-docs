using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult DragDrop()
{
        BlocksData.Add(new BlockModel() {
                id = "block-1",
                type = "Heading1",
                content = new List<ContentModel>()
                {
                        new ContentModel(){
                        type = "Text",
                        content = "Drag and Drop Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                id = "block-2",
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel() {
                                type = "Text",
                                content = "Try rearranging blocks by dragging the handle that appears when hovering over them. You can drag a single block or select multiple blocks to drag them together."
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                id = "block-3",
                type = "BulletList",
                content = new List<ContentModel>()
                {
                        new ContentModel() {
                                type = "Text",
                                content = "Drag and drop is enabled by default"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                id = "block-4",
                type = "NumberedList",
                content = new List<ContentModel>()
                {
                        new ContentModel() {
                                type = "Text",
                                content = "You can select multiple blocks and drag them together"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                id = "block-5",
                type = "NumberedList",
                content = new List<ContentModel>()
                {
                        new ContentModel() {
                                type = "Text",
                                content = "Try dragging this block to rearrange the content"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}