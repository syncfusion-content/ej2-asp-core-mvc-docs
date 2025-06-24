using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Alice Brown", StatusIconCss = "e-icons e-user-online" };
public ChatUIUser CommunityMessageUser1 { get; set; } = new ChatUIUser() { Id = "user2", User = "Michale Suyama", StatusIconCss = "e-icons e-user-away" };
public ChatUIUser CommunityMessageUser2 { get; set; } = new ChatUIUser() { Id = "user3", User = "Charlie", StatusIconCss = "e-icons e-user-busy" };
public ChatUIUser CommunityMessageUser3 { get; set; } = new ChatUIUser() { Id = "user4", User = "Jordan Peele", StatusIconCss = "e-icons e-user-offline" };

public ActionResult StatusIconCss()
{
    CurrentUser = CurrentUserModel;
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Hey Michale, Charlie! Seen the latest posts in the Design Community? Amazing projects!",
        Author = CurrentUserModel
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Hi Alice! Yes, Dana’s new UI design is incredible.",
        Author = CommunityMessageUser1
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "Dana’s work is so inspiring!",
        Author = CommunityMessageUser3
    });
    ChatMessagesData.Add(new ChatUIMessage()
    {
        Text = "I am excited to see the new projects.",
        Author = CommunityMessageUser2
    });
    ViewBag.ChatMessagesData = ChatMessagesData;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}
