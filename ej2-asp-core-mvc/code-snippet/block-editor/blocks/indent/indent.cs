using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Indent()
{
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                content = "This is a paragraph with no indentation (indent: 0)"
                        }
                },
                Indent = 0
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This paragraph has one level of indentation (indent: 1)"
                        }
                },
                Indent = 1
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This paragraph has two levels of indentation (indent: 2)"
                        }
                },
                Indent = 2
        });
        BlocksData.Add(new Block
        {
                Type = "Paragraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Back to no indentation"
                        }
                },
                Indent = 0
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}