using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Callout()
{
        BlocksData.Add(new Block() {
                Type = "Callout",
                Children = new List<Block>()
                {
                        new Block()
                        {
                                Id = "callout-content-1",
                                Type = "Paragraph",
                                Content = new List<object>(){
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