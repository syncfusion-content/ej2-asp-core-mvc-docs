using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };
public ChatUIUser MichaleUserModel { get; set; } = new ChatUIUser() { Id = "user2", User = "Michale Suyama" };

public ActionResult Timestamp()
{
    CurrentUser = CurrentUserModel;
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Hi Michale, are we on track for the deadline?",
        Author = CurrentUserModel,
        TimeStamp = new DateTime(2024,12,25,7,30,0)
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Yes, the design phase is complete.",
        Author = MichaleUserModel,
        TimeStamp = new DateTime(2024,12,25,8,0,0)
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "I’ll review it and send feedback by today.",
        Author = CurrentUserModel,
        TimeStamp = new DateTime(2024,12,25,11,0,0)
    });
    ViewBag.ChatMessagesData = ChatMessagesData;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}
