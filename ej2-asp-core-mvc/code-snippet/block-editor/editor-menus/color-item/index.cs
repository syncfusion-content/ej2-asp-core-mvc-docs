using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlockData { get; set; }
public string[] InlineToolbarItems { get; set; }
public InlineToolbarSettings InlineToolbarSettings { get; set; }
public FontColorSettings FontColorSettings { get; set; }
public BackgroundColorSettings BackgroundColorSettings { get; set; }

public class BlockModel
{
        public string id { get; set; }
        public string blockType { get; set; }
        public object properties { get; set; }
        public List<object> content { get; set; }
        public List<BlockModel> children { get; set; }
}

public ActionResult Index()
{
        InlineToolbarItems = new string[] { "Color", "Backgroundcolor" };

        BlockData = new List<BlockModel>
        {
                new BlockModel
                {
                        id = "title-block",
                        blockType = "Heading",
                        properties = new { level = 1},
                        content = new List<object>
                        {
                                new { contentType = "Text", content = "Inline Toolbar Demo" }
                        }
                },
                new BlockModel
                {
                        id = "intro-block",
                        blockType = "Quote",
                        properties = new {
                        children = new List<BlockModel>()
                        {
                                new BlockModel()
                                {
                                        id = "callout-content-1",
                                        blockType = "Paragraph",
                                        content = new List<object>
                                        {
                                                new
                                                {
                                                        contentType = "Text",
                                                        content = "Select any text in the editor to open the Inline Toolbar"
                                                }
                                        }
                                }
                        }
                        }
                }
        };
        InlineToolbarSettings = new InlineToolbarSettings()
        {
        Enable = true,
        PopupWidth = "140px",
        Items = InlineToolbarItems
        };
        FontColorSettings = new FontColorSettings()
        {
        Mode = ColorModeType.Picker,
        ModeSwitcher = true
        };
        BackgroundColorSettings = new BackgroundColorSettings()
        {
        // Handle props here
        };
        ViewData["InlineToolbarItems"] = InlineToolbarItems;
        ViewData["InlineToolbarSettings"] = InlineToolbarSettings;
        ViewData["FontColorSettings"] = FontColorSettings;
        ViewData["BackgroundColorSettings"] = BackgroundColorSettings;
        ViewData["BlockData"] = BlockData;
    return View();
}
