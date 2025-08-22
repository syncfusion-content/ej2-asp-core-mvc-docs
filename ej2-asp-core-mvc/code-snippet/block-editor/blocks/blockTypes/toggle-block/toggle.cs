using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Toggle()
{
        BlocksData.Add(new Block
        {
                Type = "CollapsibleHeading",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Collapsible Section"
                        }
                },
                Props= new
                {
                        level=1,
                        IsExpanded = true,
                        Children = new List<Block>()
                {
                        new Block()
                        {
                                Type = "Paragraph",
                                Content = new List<object>()
                                {
                                        new
                                        {
                                                type = "Text",
                                                content = "This content is inside a toggle section and can be collapsed."
                                        }
                                }
                        }
                }
                }
        });
        BlocksData.Add(new Block
        {
                Type = "CollapsibleParagraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Toggle paragraph section"
                        }
                },
                Props = new
                {
                        IsExpanded = false,
                        Children = new List<Block>()
                {
                        new Block()
                        {
                                Type = "Paragraph",
                                Content = new List<object>()
                                {
                                        new
                                        {
                                                type = "Text",
                                                content = "This content is initially hidden because isExpanded is set to false."
                                        }
                                }
                        }
                }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}