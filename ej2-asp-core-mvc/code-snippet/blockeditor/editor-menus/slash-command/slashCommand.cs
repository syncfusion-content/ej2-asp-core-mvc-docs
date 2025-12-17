using Syncfusion.EJ2.BlockEditor;

public List<BlockModel> BlocksData { get; set; }
public List<object> CommandMenuItems { get; set; }
public CommandMenuSettings CommandMenuSettings { get; set; }

public class BlockModel
{
    public string id { get; set; }
    public string blockType { get; set; }
    public object properties { get; set; }
    public List<object> content { get; set; }
}

public ActionResult SlashCommand()
{
        CommandMenuItems = new List<object>
        {
                new 
                {
                        id = "line-cmd",
                        type = "Divider",
                        groupHeader = "Utility",
                        label = "Insert a Line",
                        iconCss = "e-icons e-divider",
                },
                new 
                {
                        id = "timestamp-cmd",
                        groupHeader = "Actions",
                        label = "Insert Timestamp",
                        iconCss = "e-icons e-schedule",
                }
        };
        BlocksData = new List<BlockModel>
        {
                new BlockModel
                {
                        id = "Paragraph",
                        blockType = "Paragraph",
                        content = new List<object>
                        {
                                new { contentType = "Text", content = "Type \"/\" anywhere in this editor to open the custom slash command menu." }
                        }
                }
        };
        CommandMenuSettings = new CommandMenuSettings()
        {
                PopupWidth = "350px",
                PopupHeight = "400px",
                ItemSelect = "itemSelect",
                Filtering = "filtering",
                Commands = CommandMenuItems
        };
        ViewData["CommandMenuItems"] = CommandMenuItems;
        ViewData["CommandMenuSettings"] = CommandMenuSettings;
        ViewData["BlocksData"] = BlocksData;
        return View();
}
