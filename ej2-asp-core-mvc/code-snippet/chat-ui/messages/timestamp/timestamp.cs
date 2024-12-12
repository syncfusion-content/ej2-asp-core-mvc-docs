using Syncfusion.EJ2.InteractiveChat;

public UserModel CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public UserModel CurrentUserModel { get; set; } = new UserModel() { id = "user1", user = "Albert" };
public UserModel MichaleUserModel { get; set; } = new UserModel() { id = "user2", user = "Michale Suyama" };

public ActionResult Timestamp()
{
    CurrentUser = CurrentUserModel;
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Hi, thinking of painting this weekend.",
        Author = CurrentUserModel,
        TimeStamp = new DateTime(2024,12,25,7,30,0)
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "That’s fun! What will you paint?",
        Author = MichaleUserModel,
        TimeStamp = new DateTime(2024,12,25,8,0,0)
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Maybe landscapes.",
        Author = CurrentUserModel,
        TimeStamp = new DateTime(2024,12,25,11,0,0)
    });
    return View();
}

public class UserModel
{
    public string id { get; set; }
    public string user { get; set; }
}