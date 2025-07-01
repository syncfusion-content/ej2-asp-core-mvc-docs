using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Template()
{
        BlocksData.Add(new Block
        {
                type = "Template",
                template = "<div class=\"notification-card\">\r\n            <div class=\"notification-header\">\r\n                <span class=\"notification-icon\">📢</span>\r\n                <h3 class=\"notification-title\">Important Announcement</h3>\r\n            </div>\r\n            <div class=\"notification-content\">\r\n                <p>The system will be undergoing maintenance on Saturday from 2:00 AM to 4:00 AM.</p>\r\n                <p>Please save your work before this time to prevent any data loss.</p>\r\n            </div>\r\n        </div>"
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}