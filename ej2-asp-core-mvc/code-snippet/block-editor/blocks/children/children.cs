using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Children()
{
        BlocksData.Add(new Block
        {
                id = "security-callout",
                type = "Callout",
                children = new List<Block>()
                {
                        new Block()
                        {
                                id = "security-title",
                                parentId = "security-callout",
                                type = "Heading3",
                                content = new List<object>()
                                {
                                        new
                                        {
                                                type = "Text",
                                                content = "Security Notice"
                                        }
                                }
                        }
                }
        });
        BlocksData.Add(new Block
        {
                id = "security-warning",
                parentId = "security-callout",
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                id = "paragraph1-content",
                                type = "Text",
                                content = "Always validate user input before processing to prevent security vulnerabilities."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                id = "security-tips",
                parentId = "security-callout",
                type = "Paragraph",
                indent = 1,
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Use HTTPS for all data transmission"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                id = "security-tips-2",
                parentId = "security-callout",
                type = "Paragraph",
                indent = 1,
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Implement proper authentication mechanisms"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                id = "security-tips-3",
                parentId = "security-callout",
                type = "Paragraph",
                indent = 1,
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Regularly update dependencies and libraries"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}