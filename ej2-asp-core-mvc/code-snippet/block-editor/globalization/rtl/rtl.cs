using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Rtl()
{
        BlocksData.Add(new Block() {
                id = "block-1",
                type = "Heading1",
                content = new List<object>()
                {
                        new{
                                type = "Text",
                                content = "Sample Heading"
                        }
                }
        });
        BlocksData.Add(new Block() {
                id = "block-2",
                type = "Paragraph",
                content = new List<object>()
                {
                        new {
                                type = "Text",
                                content = "This is a sample paragraph block."
                        }
                }
        });
        BlocksData.Add(new Block()
        {
                id = "block-3",
                type = "Paragraph"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}