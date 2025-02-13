using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };
public ChatUIUser MichaleUserModel { get; set; } = new ChatUIUser() { Id = "user2", User = "Michale Suyama" };

public ActionResult AddMessageObj()
{
    CurrentUser = CurrentUserModel;
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Want to get coffee tomorrow?",
        Author = CurrentUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Sure! What time?",
        Author = MichaleUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "How about 10 AM?",
        Author = CurrentUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Perfect",
        Author = MichaleUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "See you!",
        Author = CurrentUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Bye!",
        Author = MichaleUserModel
    });
    ViewBag.ChatMessagesData = ChatMessagesData;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}
