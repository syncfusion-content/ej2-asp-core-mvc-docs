using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Placeholder()
{
        BlocksData.Add(new Block() {
                Type = "Paragraph",
                Content = new List<object>(){
                        new{
                                type = "Text",
                                content = "This is a sample paragraph block."
                        }
                }
        });
        BlocksData.Add(new Block() {
                Type = "Paragraph",
                Content = new List<object>(){
                        new{
                                type = "Text",
                                placeholder = "Start typing your notes or press \"/\" for commands..."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}