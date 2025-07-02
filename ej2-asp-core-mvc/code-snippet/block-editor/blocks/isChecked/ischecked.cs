using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult IsChecked()
{
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                content = "Task List:"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = "CheckList",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Completed task (checked)"
                        }
                },
                IsChecked = true
        });
        BlocksData.Add(new Block
        {
                Type = "CheckList",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Pending task (unchecked)"
                        }
                },
                IsChecked = false
        });
        BlocksData.Add(new Block
        {
                Type = "CheckList",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "High priority task"
                        }
                },
                IsChecked = true
        });
        BlocksData.Add(new Block
        {
                Type = "CheckList",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Low priority task"
                        }
                },
                IsChecked = false
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}