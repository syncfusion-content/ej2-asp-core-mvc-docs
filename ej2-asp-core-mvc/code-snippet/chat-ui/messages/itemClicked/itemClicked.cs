using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public List<ToolbarItemModel> MessageToolbarItems { get; set; } = new List<ToolbarItemModel>();
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };
public ChatUIUser MichaleUserModel { get; set; } = new ChatUIUser() { Id = "user2", User = "Michale Suyama" };

public ActionResult ItemClicked()
{
    CurrentUser = CurrentUserModel;
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
        Author = CurrentUserModel,
        
    });

    MessageToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-chat-forward", tooltipText = "Forward" });
    MessageToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-chat-copy", tooltipText = "Copy" });
    MessageToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-chat-reply", tooltipText = "Reply" });
    MessageToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-chat-pin", tooltipText = "Pin" });
    MessageToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-chat-trash", tooltipText = "Delete" });
    ViewBag.MessageToolbarItems = MessageToolbarItems;
    ViewBag.ChatMessagesData = ChatMessagesData;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}
