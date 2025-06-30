using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult AllowedStyle()
{
        BlocksData.Add(new BlockModel()
        {
                id = "demo-block",
                type = "Paragraph"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}