public class HomeController : Controller
{

    public ActionResult Index()
    {
        return View();
    }
    private IHostingEnvironment hostingEnv;
    public HomeController(IHostingEnvironment env)
    {
        hostingEnv = env;
    }
    public class RichTextEditorValue
    {
        public string text { get; set; }
    }
    [HttpPost]
    public ActionResult Save([FromBody]RichTextEditorValue value)
    {
        string RootPath = hostingEnv.WebRootPath + "\\js" + $@"\data.txt";
        StreamWriter writeFile = new StreamWriter(RootPath, true);
        writeFile.WriteLine(value.text);
        writeFile.Close();
        writeFile.Dispose();
        return View();
    }

}