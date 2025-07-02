using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Selection()
{
        BlocksData.Add(new Block
        {
                Id = "heading-block",
                Type = "Heading1",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Welcome to Block Editor"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "paragraph-1",
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                id = "paragraph1-content",
                                type = "Text",
                                content = "This is the first paragraph with some sample text content for selection demonstration."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "paragraph-2",
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is the second paragraph that can be used for various selection operations."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "list-block",
                Type = "BulletList",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "First list item"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}