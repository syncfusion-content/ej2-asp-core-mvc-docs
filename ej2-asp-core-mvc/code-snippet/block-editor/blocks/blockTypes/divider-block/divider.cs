using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Divider()
{
        BlocksData.Add(new BlockModel()
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "This section discusses the features of the Block Editor."
                        }
                }
        });
        BlocksData.Add(new BlockModel()
        {
                type = "Divider"
        });
        BlocksData.Add(new BlockModel()
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "This section covers implementation details and usage examples."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}