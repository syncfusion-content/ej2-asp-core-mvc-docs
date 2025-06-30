using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Locale()
{
        BlocksData.Add(new BlockModel() {
                id = "block-1",
                type = "Heading1",
                content = new List<ContentModel>()
                {
                        new ContentModel(){
                                type = "Text",
                                content = "Sample Heading"
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                id = "block-2",
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel() {
                                type = "Text",
                                content = "This is a sample paragraph block."
                        }
                }
        });
        BlocksData.Add(new BlockModel()
        {
                id = "block-3",
                type = "Paragraph"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}