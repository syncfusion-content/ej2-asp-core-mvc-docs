using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Data()
{
        BlocksData.Add(new Block
        {
                Id = "title-block",
                Type = BlockType.Heading,
                Props = new { level = 1},
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Document Export Demo"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "intro-paragraph",
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This document demonstrates the data export capabilities of the Block Editor. You can export content as JSON or HTML formats."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "features-heading",
                Type = BlockType.Heading,
                Props = new { level = 2},
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Export Features"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "features-list",
                Type = BlockType.BulletList,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "JSON export for data processing"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "features-list-2",
                Type = BlockType.BulletList,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "HTML export for web display"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "features-list-3",
                Type = BlockType.BulletList,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Print functionality for hard copies"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "code-example",
                Type = BlockType.Code,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "var data = editor.getDataAsJson();\nconsole.log(data);"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}