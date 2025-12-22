using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
    public string parentId { get; set; }
    public List<BlockModel> children { get; set; }
    public int indent { get; set; }
}

public ActionResult Children()
{
          BlocksData.Add(new BlockModel
  {
      blockType = "Callout",
      properties = new
      {
        children = new List<BlockModel>()
        {
        new BlockModel()
        {
                parentId = "security-callout",
                blockType = "Heading",
                properties = new { level = 3 },
                content = new List<object>()
                {
                        new
                        {
                                contentType = "Text",
                                content = "Security Notice"
                        }
                }
        },

        new BlockModel
        {
        parentId = "security-callout",
        blockType = "Paragraph",
        content = new List<object>()
        {
                new
                {
                        contentType = "Text",
                        content = "Always validate user input before processing to prevent security vulnerabilities."
                }
        }
        },
        new BlockModel
        {
        parentId = "security-callout",
        blockType = "Paragraph",
        indent = 1,
        content = new List<object>()
        {
                new
                {
                        contentType = "Text",
                        content = "Use HTTPS for all data transmission"
                }
        }
        },
        new BlockModel
        {
        parentId = "security-callout",
        blockType = "Paragraph",
        indent = 1,
        content = new List<object>()
        {
                new
                {
                        contentType = "Text",
                        content = "Implement proper authentication mechanisms"
                }
        }
        },
        new BlockModel
        {
        parentId = "security-callout",
        blockType = "Paragraph",
        indent = 1,
        content = new List<object>()
        {
                new
                {
                        contentType = "Text",
                        content = "Regularly update dependencies and libraries"
                }
        }
        }
                        }
        }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}
