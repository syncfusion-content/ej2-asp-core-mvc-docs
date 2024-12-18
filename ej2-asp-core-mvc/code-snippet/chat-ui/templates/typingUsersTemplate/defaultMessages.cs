using Syncfusion.EJ2.InteractiveChat;

public UserModel CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public UserModel CurrentUserModel { get; set; } = new UserModel() { id = "user1", user = "Albert" };
public UserModel MichaleUserModel { get; set; } = new UserModel() { id = "user2", user = "Michale Suyama" };
public UserModel ReenaUserModel { get; set; } = new UserModel() { id = "user3", user = "Reena" };
public List<UserModel> TypingUsers { get; set; }

public ActionResult Default()
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
        Author = CurrentUserModel
    });
    TypingUsers = new List<UserModel>() { MichaleUserModel, ReenaUserModel };
    ViewBag.ChatMessagesData = ChatMessagesData;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}

public class UserModel
{
    public string id { get; set; }
    public string user { get; set; }
}