using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Heading()
{
        BlocksData.Add(new Block
        {
                Type = "Heading1",
                Content = new List<object>()
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
                Type = "Heading2",
                Content = new List<object>()
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
                Type = "Heading3",
                Content = new List<object>()
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
                Type = "Heading4",
                Content = new List<object>()
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