using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult PlainText()
{
        BlocksData.Add(new Block()
        {
                Id = "demo-block",
                Type = "Paragraph"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}