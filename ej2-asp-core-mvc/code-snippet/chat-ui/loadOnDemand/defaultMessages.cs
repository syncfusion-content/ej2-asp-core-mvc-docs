using Syncfusion.EJ2.InteractiveChat;

public UserModel CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public UserModel CurrentUserModel { get; set; } = new UserModel() { id = "user1", user = "Albert" };
public UserModel MichaleUserModel { get; set; } = new UserModel() { id = "user2", user = "Michale Suyama" };

public ActionResult Default()
{
    CurrentUser = CurrentUserModel;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}

public class UserModel
{
    public string id { get; set; }
    public string user { get; set; }
}