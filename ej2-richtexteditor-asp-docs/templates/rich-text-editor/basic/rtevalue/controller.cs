
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public class RichTextEditorValue
    {
        public string text { get; set; }
    }

    [HttpPost]
    public ActionResult Save([FromBody]RichTextEditorValue value)
    {
        //Get the RichTextEditorValue value here
        string RTEValue = value.text;
        return View();
    }
}
