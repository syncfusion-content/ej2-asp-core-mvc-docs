using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Heading()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "Heading",
                properties = new { level = 1 },
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Main Document Title"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Heading",
                properties = new { level = 2 },
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Chapter Overview"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Heading",
                properties = new { level = 3 },
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Section Introduction"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Heading",
                properties = new { level = 4 },
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Sub-section Details"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}