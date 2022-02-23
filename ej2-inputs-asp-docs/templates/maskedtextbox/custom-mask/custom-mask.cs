namespace EJ2CoreSampleBrowser.Controllers.MaskedTextbox
{
    public partial class MaskedTextboxController : Controller
    {

        public IActionResult CustomMask()
        {
            CustomCharacters customObj = new CustomCharacters();
            customObj.P = "P,A,a,p";
            customObj.M = "M,m";
            ViewBag.cusObj = customObj;
            return View();
        }
      

    }
}
public class CustomCharacters
{
    public string P { get; set; }
    public string M { get; set; }
}