using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult Image()
{
        BlocksData.Add(new BlockModel
        {
                type = "Image",
                imageSettings = new ImageSettingsModel()
                {
                        src = "https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png",
                        altText = "Sample image"
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "Paragraph",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "You can customize images further by configuring properties like allowedTypes for file upload restrictions, saveFormat for storage preferences, and cssClass for custom styling."
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}