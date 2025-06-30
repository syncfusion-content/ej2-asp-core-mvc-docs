using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Children()
{
        BlocksData.Add(new BlockModel
        {
                id = "security-callout",
                type = "Callout",
                children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                id = "security-title",
                                parentId = "security-callout",
                                type = "Heading3",
                                content = new List<ContentModel>()
                                {
                                        new ContentModel()
                                        {
                                                type = "Text",
                                                content = "Security Notice"
                                        }
                                }
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-warning",
                parentId = "security-callout",
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                id = "paragraph1-content",
                                type = "Text",
                                content = "Always validate user input before processing to prevent security vulnerabilities."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-tips",
                parentId = "security-callout",
                type = "Paragraph",
                indent = 1,
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Use HTTPS for all data transmission"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-tips-2",
                parentId = "security-callout",
                type = "Paragraph",
                indent = 1,
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Implement proper authentication mechanisms"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "security-tips-3",
                parentId = "security-callout",
                type = "Paragraph",
                indent = 1,
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Regularly update dependencies and libraries"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}