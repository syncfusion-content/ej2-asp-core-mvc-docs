using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult IsChecked()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                content = "Task List:"
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
                                content = "Completed task (checked)"
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
                                content = "Pending task (unchecked)"
                        }
                },
                properties = new { isChecked = false }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Checklist",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "High priority task"
                        }
                },
                properties = new { isChecked = true }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "CheckList",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Low priority task"
                        }
                },
                properties = new { isChecked = false }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}