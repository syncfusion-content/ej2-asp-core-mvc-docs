using Syncfusion.EJ2.InteractiveChat;

public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public ActionResult Default()
{
    User = new UserModel
    {
        id = "user",
        user = "Albert"
    };
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Want to get coffee tomorrow?",
        Author = new UserModel()
        {
            id = "user",
            user = "Albert"
        }
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Sure! What time?",
        Author = new UserModel()
        {
            id = "user2",
            user = "Michale Suyama"
        }
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "How about 10 AM?",
        Author = new UserModel()
        {
            id = "user",
            user = "Albert"
        }
    });
    return View();
}

public class UserModel
{
    public string id { get; set; }
    public string user { get; set; }
}