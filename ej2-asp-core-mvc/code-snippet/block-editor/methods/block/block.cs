using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Block()
{
        BlocksData.Add( new Block
        {
                Id = "block-1",
                Type = "Heading1",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Sample Heading"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "block-2",
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is a sample paragraph block."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "block-3",
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is another paragraph block."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}