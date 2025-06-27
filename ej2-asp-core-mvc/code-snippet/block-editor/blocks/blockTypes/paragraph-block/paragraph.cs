using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Paragraph()
{
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "This is a paragraph block example."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}