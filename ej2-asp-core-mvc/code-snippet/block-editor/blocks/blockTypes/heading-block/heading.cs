using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Heading()
{
        BlocksData.Add(new BlockModel
        {
                type = "Heading1",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Main Document Title"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "Heading2",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Chapter Overview"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "Heading3",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Section Introduction"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "Heading4",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Sub-section Details"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}