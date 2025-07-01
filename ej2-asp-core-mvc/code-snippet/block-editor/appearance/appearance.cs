using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Appearance()
{
        BlocksData.Add(new Block
        {
                id = "title-block",
                type = "Heading1",
                content = new List<object>()
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
                id = "intro-block",
                type = "Paragraph",
                content = new List<object>()
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
                id = "features-heading",
                type = "Heading2",
                content = new List<object>()
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
                id = "theme-list-1",
                type = "BulletList",
                content = new List<object>()
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
                id = "readonly-info",
                type = "Paragraph",
                content = new List<object>()
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