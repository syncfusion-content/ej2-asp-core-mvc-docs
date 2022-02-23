using System.ComponentModel.DataAnnotations;
public class RichTextEditorModel
    {
        [Required(ErrorMessage = "Value is required")]
        // Specify AllowHtml attribute on MVC application alone
        [AllowHtml]
        public string Value { get; set; }
    }
    public partial class HomeController : Controller
    {
        RichTextEditorModel rteModel = new RichTextEditorModel();
        public ActionResult RichTextEditorFor()
        {
            rteModel.Value = "<p>Type or edit the content to post the <b>Rich Text Editor</b> value.</p>";
            return View(rteModel);
        }
        [HttpPost]
        public ActionResult RichTextEditorFor(RichTextEditorModel model)
        {
            rteModel.Value = model.Value;
            return View(rteModel);
        }
    }