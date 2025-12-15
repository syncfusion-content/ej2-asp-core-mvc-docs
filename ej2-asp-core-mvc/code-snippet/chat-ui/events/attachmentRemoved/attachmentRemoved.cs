using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };

public ActionResult AttachmentRemoved()
{
    CurrentUser = CurrentUserModel;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}
