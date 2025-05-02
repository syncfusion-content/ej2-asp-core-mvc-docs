public class HomeController : Controller
{

    public ActionResult Index()
    {
         object tools1 = new
            {
                tooltipText = "Preview",
                template = "<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn'>" +
                           "<span class='e-btn-icon e-md-preview e-icons'></span></button>"
            };
            
            ViewBag.items = new[]
            {
                "Bold", "Italic", "StrikeThrough", "|", "SuperScript",
                "SubScript", "Formats", "OrderedList", "UnorderedList" , "|", tools1 , "CreateLink", "Image", "CreateTable", "|", 
                "Undo", "Redo"
            };

            ViewBag.value = @"Hello [Albert](mailto:albert@gmail.com)\n\nWelcome to the mention integration with markdown editor demo. Type @ character and tag user from the suggestion list.";
            return View();
    }
}