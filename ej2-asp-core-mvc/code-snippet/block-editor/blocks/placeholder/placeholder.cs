using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Placeholder()
{
        BlocksData.Add(new BlockModel() {
                type = "Paragraph",
                content = new List<ContentModel>(){
                        new ContentModel(){
                                type = "Text",
                                content = "This is a sample paragraph block."
                        }
                }
        });
        BlocksData.Add(new BlockModel() {
                type = "Paragraph",
                content = new List<ContentModel>(){
                        new ContentModel(){
                                type = "Text",
                                placeholder = "Start typing your notes or press \"/\" for commands..."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}