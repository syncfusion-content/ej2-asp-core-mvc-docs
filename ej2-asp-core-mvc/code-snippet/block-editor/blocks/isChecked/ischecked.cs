using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult IsChecked()
{
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                content = "Task List:"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "CheckList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Completed task (checked)"
                        }
                },
                isChecked = true
        });
        BlocksData.Add(new BlockModel
        {
                type = "CheckList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Pending task (unchecked)"
                        }
                },
                isChecked = false
        });
        BlocksData.Add(new BlockModel
        {
                type = "CheckList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "High priority task"
                        }
                },
                isChecked = true
        });
        BlocksData.Add(new BlockModel
        {
                type = "CheckList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Low priority task"
                        }
                },
                isChecked = false
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}