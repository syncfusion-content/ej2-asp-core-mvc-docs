using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; }
public List<object> CommandMenuItems { get; set; }
public CommandMenuSettings CommandMenuSettings { get; set; }

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
        BlocksData = new List<Block>
        {
                new Block
                {
                        Id = "Paragraph",
                        Type = BlockType.Paragraph,
                        Content = new List<object>
                        {
                                new { type = "Text", content = "Type \"/\" anywhere in this editor to open the custom slash command menu." }
                        }
                }
        };
        CommandMenuSettings = new CommandMenuSettings()
        {
                EnableTooltip = false,
                PopupWidth = "350px",
                PopupHeight = "400px",
                Open = "open",
                Close = "close",
                ItemClicked = "itemClicked",
                QueryFiltering = "queryFiltering",
                Commands = CommandMenuItems
        };
        ViewData["CommandMenuItems"] = CommandMenuItems;
        ViewData["CommandMenuSettings"] = CommandMenuSettings;
        ViewData["BlocksData"] = BlocksData;
        return View();
}