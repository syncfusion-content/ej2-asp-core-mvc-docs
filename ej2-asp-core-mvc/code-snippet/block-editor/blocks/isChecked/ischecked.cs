using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult IsChecked()
{
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                content = "Task List:"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                type = "CheckList",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Completed task (checked)"
                        }
                },
                isChecked = true
        });
        BlocksData.Add(new Block
        {
                type = "CheckList",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Pending task (unchecked)"
                        }
                },
                isChecked = false
        });
        BlocksData.Add(new Block
        {
                type = "CheckList",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "High priority task"
                        }
                },
                isChecked = true
        });
        BlocksData.Add(new Block
        {
                type = "CheckList",
                content = new List<object>()
                {
                        new
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