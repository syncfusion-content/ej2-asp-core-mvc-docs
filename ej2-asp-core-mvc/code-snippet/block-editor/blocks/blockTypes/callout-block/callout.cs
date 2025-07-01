using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Callout()
{
        BlocksData.Add(new Block() {
                type = "Callout",
                children = new List<Block>()
                {
                        new Block()
                        {
                                id = "callout-content-1",
                                type = "Paragraph",
                                content = new List<object>(){
                                        new{
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