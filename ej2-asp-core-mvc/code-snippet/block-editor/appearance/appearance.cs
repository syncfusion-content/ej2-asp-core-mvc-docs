using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Appearance()
{
        BlocksData.Add(new Block
        {
                Id = "title-block",
                Type = BlockType.Heading,
                Props = new { level = 1 },
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Appearance Configuration Demo"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "intro-block",
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                id = "paragraph1-content",
                                type = "Text",
                                content = "This demo showcases different appearance configurations including readonly mode and a custom CSS theme."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "features-heading",
                Type = BlockType.Heading,
                Props = new { level = 2 },
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Configured Custom Theme"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "theme-list-1",
                Type = BlockType.BulletList,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Gradient background with modern styling"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "readonly-info",
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Use the readonly toggle to switch between editable and read-only modes. In readonly mode, you can view content but cannot make changes."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}