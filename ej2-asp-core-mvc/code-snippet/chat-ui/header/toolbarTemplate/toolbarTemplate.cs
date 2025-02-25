using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };
public ChatUIUser MichaleUserModel { get; set; } = new ChatUIUser() { Id = "user2", User = "Michale Suyama" };
public List<ToolbarItemModel> HeaderToolbar { get; set; } = new List<ToolbarItemModel>();

public ActionResult ToolbarTemplate()
{
    CurrentUser = CurrentUserModel;
    HeaderToolbar.Add(new ToolbarItemModel { type= "Input", align = "right", template= "<div id=\"ddMenu\"></div>" });
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

public class ToolbarItemModel
{
    public string align { get; set; }
    public string type { get; set; }
    public string template { get; set; }
}
