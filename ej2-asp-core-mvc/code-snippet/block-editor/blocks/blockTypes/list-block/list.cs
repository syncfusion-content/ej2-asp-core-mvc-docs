using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult List()
{
        BlocksData.Add(new Block
        {
                Type = "BulletList",
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "Features of the Block Editor"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = "NumberedList",
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "Step 1: Initialize the Block Editor"
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
                                content = "Review documentation"
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
                                content = "Implement drag and drop functionality"
                        }
                },
                IsChecked = false
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}