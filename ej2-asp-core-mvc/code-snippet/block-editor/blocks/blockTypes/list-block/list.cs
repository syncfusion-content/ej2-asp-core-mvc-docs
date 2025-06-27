using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; } = new List<BlockModel>();

public ActionResult List()
{
        BlocksData.Add(new BlockModel
        {
                type = "BulletList",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Features of the Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "NumberedList",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Step 1: Initialize the Block Editor"
                        }
                }
        });
        BlocksData.Add(new BlockModel
        {
                type = "CheckList",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Review documentation"
                        }
                },
                isChecked = true
        });
        BlocksData.Add(new BlockModel
        {
                type = "CheckList",
                content = new List<ContentModel>()
                {
                        new ContentModel
                        {
                                type = "Text",
                                content = "Implement drag and drop functionality"
                        }
                },
                isChecked = false
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}