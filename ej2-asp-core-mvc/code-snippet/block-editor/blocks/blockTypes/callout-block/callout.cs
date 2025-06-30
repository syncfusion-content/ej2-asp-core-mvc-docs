using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Callout()
{
        BlocksData.Add(new BlockModel() {
                type = "Callout",
                children = new List<BlockModel>()
                {
                        new BlockModel()
                        {
                                id = "callout-content-1",
                                type = "Paragraph",
                                content = new List<ContentModel>(){
                                        new ContentModel(){
                                                id = "callout-content-1",
                                                type = "Text",
                                                content = "Important information: This is a callout block used to highlight important content."
                                        }
                                }
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}