using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult CssClass()
{
        BlocksData.Add(new Block
        {
                Type = "Heading1",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Custom CSS Classes in Block Editor"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                content = "Default paragraph block"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is an info block"
                        }
                },
                CssClass = "info-block"
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is a warning block"
                        }
                },
                CssClass = "warning-block"
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is a success block"
                        }
                },
                CssClass = "success-block"
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is an error block"
                        }
                },
                CssClass = "error-block"
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is a custom font block"
                        }
                },
                CssClass = "custom-font"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}