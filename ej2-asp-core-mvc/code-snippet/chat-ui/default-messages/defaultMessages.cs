using Syncfusion.EJ2.InteractiveChat;

public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public UserModel AlberUserModel { get; set; } = new UserModel() { id = "user1", user = "Albert" };
public UserModel MichaleUserModel { get; set; } = new UserModel() { id = "user2", user = "Michale Suyama" };

public ActionResult Default()
{
    User = AlberUserModel;
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Id = "msg1",
        Text = "Want to get coffee tomorrow?",
        Author = AlberUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Id = "msg2",
        Text = "Sure! What time?",
        Author = MichaleUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Id = "msg3",
        Text = "How about 10 AM?",
        Author = AlberUserModel
    });
    return View();
}

public class UserModel
{
    public string id { get; set; }
    public string user { get; set; }
}