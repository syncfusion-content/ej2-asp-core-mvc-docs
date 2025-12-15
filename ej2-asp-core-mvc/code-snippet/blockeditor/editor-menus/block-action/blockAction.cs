using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();
public List<object> BlockItems { get; set; }
public BlockActionMenuSettings BlockActionMenuSettings { get; set; }

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult BlockAction()
{
        BlocksData.Add(new BlockModel() {
                id = "title-block",
                blockType = "Heading",
                properties = new { level = 1},
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "Block Action Menu Demo"
                        }
                }
        });
        BlocksData.Add(new BlockModel()
        {
                id = "intro-block",
                blockType = "Quote",
                content = new List<object>()
                {
                        new {
                                contentType = "Text",
                                content = "Hover over any block and click the drag handle icon to see custom actions."
                        }
                }
        });
        BlockItems = new List<object>()
        {
                new
                {
                        id = "highlight-action",
                        label = "Highlight Block",
                        iconCss = "e-icons e-highlight",
                        tooltip = "Highlight this block"
                },
                new
                {
                        id = "copy-content-action",
                        label = "Copy Content",
                        iconCss = "e-icons e-copy",
                        tooltip = "Copy block content to clipboard"
                },
                new
                {
                        id = "block-info-action",
                        label = "Block Info",
                        tooltip = "Show block information"
                }
        };
        BlockActionMenuSettings = new BlockActionMenuSettings()
        {
                Enable = true,
                EnableTooltip = false,
                PopupHeight = "110px",
                PopupWidth = "180px",
                Open = "open",
                Close = "close",
                ItemClick = "itemClick",
                Items = BlockItems
        };
        ViewData.BlockActionMenuSettings = BlockActionMenuSettings;
        ViewBag.BlockItems = BlockItems;
        ViewBag.BlocksData = BlocksData;
        return View();
}