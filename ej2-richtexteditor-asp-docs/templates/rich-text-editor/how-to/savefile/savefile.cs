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
        public ActionResult Save([System.Web.Http.FromBody]RichTextEditorValue value)
        {
            string RootPath = Server.MapPath("~/data.txt");
            StreamWriter writeFile = new StreamWriter(RootPath, true);
            writeFile.WriteLine(value.text);
            writeFile.Close();
            writeFile.Dispose();
            return View();
        }

    }