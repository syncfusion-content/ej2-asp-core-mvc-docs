using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Toggle()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "CollapsibleHeading",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Collapsible Section"
                        }
                },
                properties = new
                {
                        level=1,
                        isExpanded = true,
                        children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                blockType = "Paragraph",
                                content = new List<object>()
                                {
                                        new
                                        {
                                                contentType = "Text",
                                                content = "This content is inside a toggle section and can be collapsed."
                                        }
                                }
                        }
                }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "CollapsibleParagraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Toggle paragraph section"
                        }
                },
                properties = new
                {
                        isExpanded = false,
                        children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                blockType = "Paragraph",
                                content = new List<object>()
                                {
                                        new
                                        {
                                                contentType = "Text",
                                                content = "This content is initially hidden because isExpanded is set to false."
                                        }
                                }
                        }
                }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}