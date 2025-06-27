using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Toggle()
{
        BlocksData.Add(new BlockModel
        {
                type = "ToggleHeading1",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Collapsible Section"
                        }
                },
                isExpanded = true,
                children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                type = "Paragraph",
                                content = new List<ContentModel>()
                                {
                                        new ContentModel()
                                        {
                                                type = "Text",
                                                content = "This content is inside a toggle section and can be collapsed."
                                        }
                                }
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "ToggleParagraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Toggle paragraph section"
                        }
                },
                isExpanded = false,
                children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                type = "Paragraph",
                                content = new List<ContentModel>()
                                {
                                        new ContentModel()
                                        {
                                                type = "Text",
                                                content = "This content is initially hidden because isExpanded is set to false."
                                        }
                                }
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}