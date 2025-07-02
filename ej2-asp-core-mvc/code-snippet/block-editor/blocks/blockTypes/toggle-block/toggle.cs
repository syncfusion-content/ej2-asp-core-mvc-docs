using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Toggle()
{
        BlocksData.Add(new Block
        {
                Type = "ToggleHeading1",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Collapsible Section"
                        }
                },
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
        });
        BlocksData.Add(new Block
        {
                Type = "ToggleParagraph",
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Toggle paragraph section"
                        }
                },
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
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}