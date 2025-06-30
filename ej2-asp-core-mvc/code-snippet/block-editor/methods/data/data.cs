using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Data()
{
        BlocksData.Add(new BlockModel
        {
                id = "title-block",
                type = "Heading1",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Document Export Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "intro-paragraph",
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "This document demonstrates the data export capabilities of the Block Editor. You can export content as JSON or HTML formats."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-heading",
                type = "Heading2",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Export Features"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-list",
                type = "BulletList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "JSON export for data processing"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-list-2",
                type = "BulletList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "HTML export for web display"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "features-list-3",
                type = "BulletList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Print functionality for hard copies"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "code-example",
                type = "Code",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "var data = editor.getDataAsJson();\nconsole.log(data);"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}