using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Children()
{
        BlocksData.Add(new Block
        {
                Id = "security-callout",
                Type = BlockType.Callout,
                Props = new {
                Children = new List<Block>()
                {
                        new Block()
                        {
                                Id = "security-title",
                                Parentid = "security-callout",
                                Type = BlockType.Heading,
                                Props = new { level = 3 },
                                Content = new List<object>()
                                {
                                        new
                                        {
                                                type = "Text",
                                                content = "Security Notice"
                                        }
                                }
                        }
                }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "security-warning",
                ParentId = "security-callout",
                Type = BlockType.Paragraph,
                Content = new List<object>()
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
                Id = "security-tips",
                ParentId = "security-callout",
                Type = BlockType.Paragraph,
                Indent = 1,
                Content = new List<object>()
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
                Id = "security-tips-2",
                ParentId = "security-callout",
                Type = BlockType.Paragraph,
                Indent = 1,
                Content = new List<object>()
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
                Id = "security-tips-3",
                ParentId = "security-callout",
                Type = BlockType.Paragraph,
                Indent = 1,
                Content = new List<object>()
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