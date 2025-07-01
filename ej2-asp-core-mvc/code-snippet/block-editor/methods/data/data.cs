using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Data()
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
                                content = "Document Export Demo"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                id = "intro-paragraph",
                type = "Paragraph",
                content = new List<object>()
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
                id = "features-heading",
                type = "Heading2",
                content = new List<object>()
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
                id = "features-list",
                type = "BulletList",
                content = new List<object>()
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
                id = "features-list-2",
                type = "BulletList",
                content = new List<object>()
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
                id = "features-list-3",
                type = "BulletList",
                content = new List<object>()
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
                id = "code-example",
                type = "Code",
                content = new List<object>()
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