using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult List()
{
        BlocksData.Add(new Block
        {
                type = "BulletList",
                content = new List<object>()
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
                type = "NumberedList",
                content = new List<object>()
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
                type = "CheckList",
                content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "Review documentation"
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
                                content = "Implement drag and drop functionality"
                        }
                },
                isChecked = false
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}