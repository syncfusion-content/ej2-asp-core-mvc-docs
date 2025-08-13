using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; }
public List<object> ContextMenuItems { get; set; }
public ContextMenuSettings ContextMenuSettings { get; set; }

public ActionResult ContextMenu()
{
        var Items1 = new List<object>(){
                new {
                        id = "bold-item",
                        text = "Bold",
                        iconCss = "e-icons e-bold",
                },
                new {
                        id = "italic-item",
                        text = "Italic",
                        iconCss = "e-icons e-italic",
                },
                        new {
                        id = "underline-item",
                        text = "Underline",
                        iconCss = "e-icons e-underline",
                }
        };
        var Items2 = new List<object>(){
                new {
                        id = "export-json",
                        text = "Export as JSON",
                        iconCss = "e-icons e-file-json",
                },
                new {
                        id = "export-html",
                        text = "Export as HTML",
                        iconCss = "e-icons e-file-html",
                },
                        new {
                        id = "export-pdf",
                        text = "Export as PDF",
                        iconCss = "e-icons e-file-pdf",
                }
        };
        ContextMenuItems = new List<object>
                {
                new {
                        id = "format-menu",
                        text = "Format",
                        iconCss = "e-icons e-format-painter",
                        items = Items1
                },
                new { separator = true },
                new {
                        id = "statistics-item",
                        text = "Block Statistics",
                        iconCss = "e-icons e-chart"
                },
                new {
                        id = "export-item",
                        text = "Export Options",
                        iconCss = "e-icons e-export",
                        items = Items2
                }
        };
        BlocksData = new List<Block>
        {
                new Block
                {
                        Id = "title-block",
                        Type = BlockType.Heading,
                        Props = new { level = 1},
                        Content = new List<object>
                        {
                                new { type = "Text", content = "Context Menu Demo" }
                        }
                },
                new Block
                {
                        Id = "intro-block",
                        Type = BlockType.Quote,
                        Content = new List<object>
                        {
                                new
                                {
                                        type = "Text",
                                        content = "Right-click anywhere in this editor to open the custom context menu. Try different areas and blocks."
                                }
                        }
                }
        };
        ContextMenuSettings = new ContextMenuSettings()
        {
                Enable = true,
                ShowItemOnClick = true,
                BeforeClose = "beforeClose",
                BeforeOpen = "beforeOpen",
                Open = "open",
                Close = "close",
                ItemClick = "itemClick",
                Items = ContextMenuItems
        };
        ViewData["ContextMenuItems"] = ContextMenuItems;
        ViewData["ContextMenuSettings"] = ContextMenuSettings;
        ViewData["BlocksData"] = BlocksData;
        return View();
}