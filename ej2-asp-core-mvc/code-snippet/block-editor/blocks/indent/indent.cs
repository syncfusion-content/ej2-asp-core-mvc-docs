using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Indent()
{
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                content = "This is a paragraph with no indentation (indent: 0)"
                        }
                },
                indent = 0
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This paragraph has one level of indentation (indent: 1)"
                        }
                },
                indent = 1
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "This paragraph has two levels of indentation (indent: 2)"
                        }
                },
                indent = 2
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Back to no indentation"
                        }
                },
                indent = 0
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}