using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
    public int indent { get; set; }
}

public ActionResult Indent()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                content = "This is a paragraph with no indentation (indent: 0)"
                        }
                },
                indent= 0
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This paragraph has one level of indentation (indent: 1)"
                        }
                },
                indent= 1
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This paragraph has two levels of indentation (indent: 2)"
                        }
                },
                indent= 2
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Back to no indentation"
                        }
                },
                indent = 0
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}