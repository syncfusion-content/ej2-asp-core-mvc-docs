public class HomeController : Controller
{
    public ActionResult Index()
    {
         ViewBag.value = @"<p>In Rich text Editor, the enter key and shift + enter key actions can be customized using the enterKey and shiftEnterKey APIs. And the possible values are as follows:</p>
        <ul>
            <li>P - When 'P' is configured, pressing enter or shift + enter will create a 'p' tag</li>
            <li>DIV - When 'DIV' is configured, pressing enter or shift + enter will create a 'div' tag</li>
            <li>BR - When 'BR' is configured, pressing enter or shift + enter will create a 'br' tag</li>
        </ul>";
        return View();
    }
}