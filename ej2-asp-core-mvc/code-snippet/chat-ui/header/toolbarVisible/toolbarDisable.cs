using Syncfusion.EJ2.InteractiveChat;

public UserModel CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public UserModel CurrentUserModel { get; set; } = new UserModel() { id = "user1", user = "Albert" };
public UserModel MichaleUserModel { get; set; } = new UserModel() { id = "user2", user = "Michale Suyama" };
public List<ToolbarItemModel> HeaderToolbar { get; set; } = new List<ToolbarItemModel>();

public ActionResult ToolbarDisable()
{
    CurrentUser = CurrentUserModel;
    HeaderToolbar.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh", visible = false });
    HeaderToolbar.Add(new ToolbarItemModel { align="Right", iconCss= "e-icons e-user" });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Hi Michale, are we on track for the deadline?",
        Author = CurrentUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Yes, the design phase is complete.",
        Author = MichaleUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "I’ll review it and send feedback by today.",
        Author = CurrentUserModel
    });
    ViewBag.ChatMessagesData = ChatMessagesData;
    ViewBag.CurrentUser = CurrentUser;
    ViewBag.HeaderToolbar = HeaderToolbar;
    return View();
}

public class UserModel
{
    public string id { get; set; }
    public string user { get; set; }
}

public class ToolbarItemModel
{
    public string align { get; set; }
    public string iconCss { get; set; }
    public bool visible { get; set; }
}