using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Paragraph()
{
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "This is a paragraph block example."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}