using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Quote()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "Quote",
                content = new List<object>()
                {
                        new 
                        {
                                contentType = "Text",
                                content = "The greatest glory in living lies not in never falling, but in rising every time we fall."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}