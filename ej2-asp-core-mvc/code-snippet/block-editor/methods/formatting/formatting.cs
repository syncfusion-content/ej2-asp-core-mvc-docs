using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Formatting()
{
        BlocksData.Add(new Block
        {
                Id = "sample-heading",
                Type = BlockType.Heading,
                Props = new { level = 1},
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Formatting Demo"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "sample-paragraph-1",
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Select this text and apply different formatting options using the buttons below. You can make text bold or change colors for the text."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Id = "sample-list",
                Type = BlockType.BulletList,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "List item for formatting demonstration"
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}