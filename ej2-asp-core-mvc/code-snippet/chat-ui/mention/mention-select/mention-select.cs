using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public List<ChatUIUser> MentionUsers { get; set; } = new List<ChatUIUser>();
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };
public ChatUIUser MichaleUserModel { get; set; } = new ChatUIUser() { Id = "user2", User = "Michale Suyama" };

public ActionResult Default()
{
    CurrentUser = CurrentUserModel;
    MentionUsers.Add(CurrentUserModel);
    MentionUsers.Add(new ChatUIUser() { Id = "custom-user", User = "Reena" });
    ViewBag.CurrentUser = CurrentUser;
    ViewBag.MentionUsers = MentionUsers;
    return View();
}
