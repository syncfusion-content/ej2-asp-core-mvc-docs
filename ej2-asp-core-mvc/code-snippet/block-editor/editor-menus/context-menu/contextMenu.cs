using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; }
public List<object> ContextMenuItems { get; set; }
public ContextMenuSettings ContextMenuSettings { get; set; }

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

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
        BlocksData = new List<BlockModel>
        {
                new BlockModel
                {
                        id = "title-block",
                        blockType = "Heading",
                        properties = new { level = 1},
                        content = new List<object>
                        {
                                new { contentType = "Text", content = "Context Menu" }
                        }
                },
                new BlockModel
                {
                        id = "paragraph-block",
                        blockType = "Paragraph",
                        content = new List<object>
                        {
                                new { contentType = "Text", content = "This is a sample text with a " },
                                new {
                                        contentType = "Link",
                                        content = "link",
                                        url = "https://ej2.syncfusion.com/documentation/block-editor/getting-started",
                                        title = "Block Editor Documentation"
                                },
                                new { contentType = "Text", content = ". Right-click the link to see link context menu options." }
                        }
                },
                new BlockModel
                {
                        id = "link-quote-block",
                        blockType = "Quote",
                        properties = new {
                                children = new List<object>
                                {
                                        new {
                                                id = "link-quote-paragraph",
                                                blockType = "Paragraph",
                                                content = new List<object>
                                                {
                                                        new {
                                                                contentType = "Text",
                                                                content = "When the cursor is focused on a link, right-click to open the context menu with options like Open Link, Edit Link, Copy Link, and Remove Link."
                                                        }
                                                }
                                        }
                                }
                        }
                },
                new BlockModel
                {
                        id = "table-block",
                        blockType = "Table",
                        properties = new {
                                columns = new List<object>
                                {
                                        new { id = "col1", headerText = "Column 1" },
                                        new { id = "col2", headerText = "Column 2" }
                                },
                                rows = new List<object>
                                {
                                        new {
                                                cells = new List<object>
                                                {
                                                        new {
                                                                columnId = "col1",
                                                                blocks = new List<object>
                                                                {
                                                                        new {
                                                                                id = "cell1-paragraph",
                                                                                blockType = "Paragraph",
                                                                                content = new List<object>
                                                                                {
                                                                                        new { contentType = "Text", content = "Cell 1" }
                                                                                }
                                                                        }
                                                                }
                                                        },
                                                        new {
                                                                columnId = "col2",
                                                                blocks = new List<object>
                                                                {
                                                                        new {
                                                                                id = "cell2-paragraph",
                                                                                blockType = "Paragraph",
                                                                                content = new List<object>
                                                                                {
                                                                                        new { contentType = "Text", content = "Cell 2" }
                                                                                }
                                                                        }
                                                                }
                                                        }
                                                }
                                        },
                                        new {
                                                cells = new List<object>
                                                {
                                                        new {
                                                                columnId = "col1",
                                                                blocks = new List<object>
                                                                {
                                                                        new {
                                                                                id = "cell3-paragraph",
                                                                                blockType = "Paragraph",
                                                                                content = new List<object>
                                                                                {
                                                                                        new { contentType = "Text", content = "Cell 3" }
                                                                                }
                                                                        }
                                                                }
                                                        },
                                                        new {
                                                                columnId = "col2",
                                                                blocks = new List<object>
                                                                {
                                                                        new {
                                                                                id = "cell4-paragraph",
                                                                                blockType = "Paragraph",
                                                                                content = new List<object>
                                                                                {
                                                                                        new { contentType = "Text", content = "Cell 4" }
                                                                                }
                                                                        }
                                                                }
                                                        }
                                                }
                                        }
                                }
                        }
                },
                new BlockModel
                {
                        id = "table-quote-block",
                        blockType = "Quote",
                        properties = new {
                                children = new List<object>
                                {
                                        new {
                                                id = "table-quote-paragraph",
                                                blockType = "Paragraph",
                                                content = new List<object>
                                                {
                                                        new {
                                                                contentType = "Text",
                                                                content = "Right-click inside a table cell to open the context menu, where you can access options such as inserting or deleting rows/columns and formatting the table."
                                                        }
                                                }
                                        }
                                }
                        }
                }
        };
        ContextMenuSettings = new ContextMenuSettings()
        {
                Enable = true,
                ShowItemOnClick = true,
                Opening = "open",
                Closing = "close",
                ItemSelect = "itemClick",
                Items = ContextMenuItems
        };
        ViewData["ContextMenuItems"] = ContextMenuItems;
        ViewData["ContextMenuSettings"] = ContextMenuSettings;
        ViewData["BlocksData"] = BlocksData;
        return View();
}
