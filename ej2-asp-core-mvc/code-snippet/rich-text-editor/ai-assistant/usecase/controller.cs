public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewData["RTEValue"] = "<p>Dear Valued Customer,</p>\r\n<p>We are writing to inform you that there has been a recent change to our policies that may affect your account. Please take a moment to review the details below carefully.</p>\r\n<p>Starting next Monday, all users must update their personal information before accessing the system. Failure to do so may result in the temporary suspension of your account and loss of access to certain features.</p>\r\n<p>If you have any questions or concerns, please feel free to contact our support team at <a href=\"\"mailto:support@companyname.com\"\">support@companyname.com</a>. They are available 24/7 and happy to help.</p>\r\n<p>Thank you for your time and cooperation. We apologize for any inconvenience this may cause.</p>\r\n<p>Best regards,</p>\r\n<p>Customer Support Team</p>\r\n<p>Company Name</p>";
        ViewBag.items = new[] { "AICommands", "AIQuery" };
        return View();
    }
}