using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult Placeholder()
{
        BlocksData.Add(new BlockModel() {
                blockType = "Paragraph",
                content = new List<object>(){
                        new{
                                contentType = "Text",
                                content = "This is a sample paragraph block."
                        }
                }
        });
        BlocksData.Add(new BlockModel()
                {
                
                        blockType = "Paragraph",
                        properties = new { placeholder = "Start typing your notes or press \"/\" for commands..." }
                });
        ViewBag.BlocksData = BlocksData;
        return View();
}
