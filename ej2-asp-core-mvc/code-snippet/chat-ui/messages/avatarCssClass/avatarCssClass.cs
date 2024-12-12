using Syncfusion.EJ2.InteractiveChat;

public UserModel CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public UserModel CurrentUserModel { get; set; } = new UserModel() { id = "user1", user = "Albert" };
public UserModel MichaleUserModel { get; set; } = new UserModel() { id = "user2", user = "Michale Suyama", cssClass = "custom-user" };

public ActionResult AvatarCssClass()
{
    CurrentUser = CurrentUserModel;
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Hi, thinking of painting this weekend.",
        Author = CurrentUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "That’s fun! What will you paint?",
        Author = MichaleUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Maybe landscapes.",
        Author = CurrentUserModel
    });
    return View();
}

public class UserModel
{
    public string id { get; set; }
    public string user { get; set; }
    public string cssClass { get; set; }
}