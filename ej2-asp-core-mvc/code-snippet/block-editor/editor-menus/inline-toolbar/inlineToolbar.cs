using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; }
public List<object> InlineToolbarItems { get; set; }
public InlineToolbarSettings InlineToolbarSettings { get; set; }

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
        BlocksData = new List<Block>
        {
                new Block
                {
                        Id = "title-block",
                        Type = "Heading1",
                        Content = new List<object>
                        {
                                new { type = "Text", content = "Inline Toolbar Demo" }
                        }
                },
                new Block
                {
                        Id = "intro-block",
                        Type = "Quote",
                        Content = new List<object>
                        {
                                new
                                {
                                        type = "Text",
                                        content = "Select any text in the editor to open the Inline Toolbar"
                                }
                        }
                }
        };
        InlineToolbarSettings = new InlineToolbarSettings()
        {
                Enable = true,
                EnableTooltip = true,
                Width = "80px",
                Open = "open",
                Close = "close",
                ItemClicked = "itemClicked",
                Items = InlineToolbarItems
        };
        ViewData["InlineToolbarItems"] = InlineToolbarItems;
        ViewData["InlineToolbarSettings"] = InlineToolbarSettings;
        ViewData["BlocksData"] = BlocksData;
        return View();
}