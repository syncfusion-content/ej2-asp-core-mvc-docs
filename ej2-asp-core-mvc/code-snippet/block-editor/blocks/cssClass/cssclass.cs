using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult CssClass()
{
        BlocksData.Add(new Block
        {
                type = "Heading1",
                content = new List<object>()
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
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                content = "Default paragraph block"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is an info block"
                        }
                },
                cssClass = "info-block"
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is a warning block"
                        }
                },
                cssClass = "warning-block"
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is a success block"
                        }
                },
                cssClass = "success-block"
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is an error block"
                        }
                },
                cssClass = "error-block"
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This is a custom font block"
                        }
                },
                cssClass = "custom-font"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}