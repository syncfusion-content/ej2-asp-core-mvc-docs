public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = @"<blockquote>
        <p><strong>Outer Quote:</strong> The Rich Text Editor provides a flexible way to format quotations.</p>
        <blockquote>
            <p><em>Inner Quote:</em> You can even nest blockquotes to represent quoted replies or layered citations.</p>
            <blockquote>
                <p><em>Deep Quote:</em> This is useful in forums, emails, or academic writing where multiple levels of quoting are needed.</p>
            </blockquote>
        </blockquote>
    </blockquote>";
            return View();
    }
}