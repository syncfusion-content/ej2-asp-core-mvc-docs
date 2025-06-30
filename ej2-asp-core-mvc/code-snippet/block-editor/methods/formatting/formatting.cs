using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Formatting()
{
        BlocksData.Add(new BlockModel
        {
                id = "sample-heading",
                type = "Heading1",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Formatting Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "sample-paragraph-1",
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "Select this text and apply different formatting options using the buttons below. You can make text bold or change colors for the text."
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                id = "sample-list",
                type = "BulletList",
                content = new List<ContentModel>()
                {
                        new ContentModel()
                        {
                                type = "Text",
                                content = "List item for formatting demonstration"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}