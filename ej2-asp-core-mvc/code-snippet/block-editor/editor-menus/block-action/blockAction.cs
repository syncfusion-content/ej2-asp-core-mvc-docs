using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();
public List<object> BlockItems { get; set; }
public BlockActionMenuSettings BlockActionMenuSettings { get; set; }

public ActionResult BlockAction()
{
        BlocksData.Add(new Block() {
                Id = "title-block",
                Type = "Heading1",
                Content = new List<object>()
                {
                        new {
                                type = "Text",
                                content = "Block Action Menu Demo"
                        }
                }
        });
        BlocksData.Add(new Block()
        {
                Id = "intro-block",
                Type = "Quote",
                Content = new List<object>()
                {
                        new {
                                type = "Text",
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