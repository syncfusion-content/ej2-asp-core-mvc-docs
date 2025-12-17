using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; }
public List<object> InlineToolbarItems { get; set; }
public InlineToolbarSettings InlineToolbarSettings { get; set; }

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult InlineToolbar()
{
        InlineToolbarItems = new List<object>
        {
                new {
                        id = "clear", 
                        iconCss = "e-icons e-format-painter", 
                        item = "Custom", 
                        tooltip = "Format Painter" 
                },
                new { 
                        id = "highlight",
                        iconCss = "e-icons e-highlight",
                        item = "Custom",
                        tooltip = "Highlight"
                }
        };
        BlocksData = new List<BlockModel>
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
                        content = new List<object>
                        {
                                new
                                {
                                        contentType = "Text",
                                        content = "Select any text in the editor to open the Inline Toolbar"
                                }
                        }
                }
        };
        InlineToolbarSettings = new InlineToolbarSettings()
        {
                Enable = true,
                PopupWidth = "80px",
                ItemClick = "itemClicked",
                Items = InlineToolbarItems
        };
        ViewData["InlineToolbarItems"] = InlineToolbarItems;
        ViewData["InlineToolbarSettings"] = InlineToolbarSettings;
        ViewData["BlocksData"] = BlocksData;
        return View();
}
