using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Toggle()
{
        BlocksData.Add(new Block
        {
                type = "ToggleHeading1",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Collapsible Section"
                        }
                },
                isExpanded = true,
                children = new List<Block>()
                {
                        new Block()
                        {
                                type = "Paragraph",
                                content = new List<object>()
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
                type = "ToggleParagraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Toggle paragraph section"
                        }
                },
                isExpanded = false,
                children = new List<Block>()
                {
                        new Block()
                        {
                                type = "Paragraph",
                                content = new List<object>()
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