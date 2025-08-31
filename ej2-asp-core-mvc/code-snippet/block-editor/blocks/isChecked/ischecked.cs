using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult IsChecked()
{
        BlocksData.Add(new Block
        {
                Type = BlockType.Paragraph,
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
                Type = BlockType.Checklist,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Completed task (checked)"
                        }
                },
                Props = new { isChecked = true }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.Checklist,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Pending task (unchecked)"
                        }
                },
                Props = new { isChecked = false }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.Checklist,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "High priority task"
                        }
                },
                Props = new { isChecked = true }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.CheckList,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Low priority task"
                        }
                },
                Props = new { isChecked = false }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}