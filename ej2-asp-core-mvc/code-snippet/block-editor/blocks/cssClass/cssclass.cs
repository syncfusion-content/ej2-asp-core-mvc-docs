using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult CssClass()
{
        BlocksData.Add(new BlockModel
        {
                type = "Heading1",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Custom CSS Classes in Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                content = "Default paragraph block"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "This is an info block"
                        }
                },
                cssClass = "info-block"
        });
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "This is a warning block"
                        }
                },
                cssClass = "warning-block"
        });
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "This is a success block"
                        }
                },
                cssClass = "success-block"
        });
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "This is an error block"
                        }
                },
                cssClass = "error-block"
        });
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "This is a custom font block"
                        }
                },
                cssClass = "custom-font"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}