using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Quote()
{
        BlocksData.Add(new BlockModel
        {
                type = "Quote",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "The greatest glory in living lies not in never falling, but in rising every time we fall."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}