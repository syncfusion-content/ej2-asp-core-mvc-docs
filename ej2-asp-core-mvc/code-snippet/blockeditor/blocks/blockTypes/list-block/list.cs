using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult List()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "BulletList",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Features of the Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "NumberedList",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Step 1: Initialize the Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Checklist",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Review documentation"
                        }
                },
                properties = new { isChecked = true }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Checklist",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "Implement drag and drop functionality"
                        }
                },
                properties = new { isChecked = false }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}