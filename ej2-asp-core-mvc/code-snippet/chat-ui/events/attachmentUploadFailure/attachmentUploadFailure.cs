using Syncfusion.EJ2.InteractiveChat;

public ChatUIUser CurrentUser { get; set; }
public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };

public ActionResult AttachmentUploadFailure()
{
    CurrentUser = CurrentUserModel;
    ViewBag.CurrentUser = CurrentUser;
    return View();
}
