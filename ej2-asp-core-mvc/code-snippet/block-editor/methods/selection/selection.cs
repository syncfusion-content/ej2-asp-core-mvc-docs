using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Selection()
{
        BlocksData.Add(new BlockModel
        {
                id = "heading-block",
                type = "Heading1",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Welcome to Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "paragraph-1",
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                id = "paragraph1-content",
                                type = "Text",
                                content = "This is the first paragraph with some sample text content for selection demonstration."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "paragraph-2",
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "This is the second paragraph that can be used for various selection operations."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "list-block",
                type = "BulletList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "First list item"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}