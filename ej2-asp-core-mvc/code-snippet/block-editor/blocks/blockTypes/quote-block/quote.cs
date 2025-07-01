using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Quote()
{
        BlocksData.Add(new Block
        {
                type = "Quote",
                content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "The greatest glory in living lies not in never falling, but in rising every time we fall."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}