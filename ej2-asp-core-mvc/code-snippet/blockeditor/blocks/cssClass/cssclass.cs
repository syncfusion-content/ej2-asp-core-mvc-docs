using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult CssClass()
{
        BlocksData.Add(new BlockModel
        {
                blockType = "Heading",
                properties = new { level = 1 },
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Custom CSS Classes in Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                content = "Default paragraph block"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This is an info block"
                        }
                },
                CssClass = "info-block"
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This is a warning block"
                        }
                },
                CssClass = "warning-block"
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This is a success block"
                        }
                },
                CssClass = "success-block"
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This is an error block"
                        }
                },
                CssClass = "error-block"
        });
        BlocksData.Add(new BlockModel
        {
                blockType = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "This is a custom font block"
                        }
                },
                CssClass = "custom-font"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}