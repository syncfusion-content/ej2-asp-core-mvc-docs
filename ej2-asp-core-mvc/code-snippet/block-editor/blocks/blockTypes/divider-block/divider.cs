using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Divider()
{
        BlocksData.Add(new Block()
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "This section discusses the features of the Block Editor."
                        }
                }
        });
        BlocksData.Add(new Block()
        {
                Type = "Divider"
        });
        BlocksData.Add(new Block()
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "This section covers implementation details and usage examples."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}