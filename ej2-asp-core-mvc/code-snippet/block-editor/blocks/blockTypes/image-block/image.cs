using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Image()
{
        BlocksData.Add(new Block
        {
                Type = BlockType.Image,
                Props = new
                {
                        src = "https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png",
                        altText = "Sample image"
                }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "You can customize images further by configuring properties like allowedTypes for file upload restrictions, saveFormat for storage preferences, and cssClass for custom styling."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}