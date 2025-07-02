using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Heading()
{
        BlocksData.Add(new Block
        {
                type = "Heading1",
                content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "Main Document Title"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                type = "Heading2",
                content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "Chapter Overview"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                type = "Heading3",
                content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "Section Introduction"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                type = "Heading4",
                content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "Sub-section Details"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}