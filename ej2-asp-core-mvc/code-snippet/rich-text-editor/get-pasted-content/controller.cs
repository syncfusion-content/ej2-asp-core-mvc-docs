    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.value = @"<p>RichTextEditor is a WYSIWYG editing control which will reduce the effort for users while trying to express their formatting word content as HTML format.</p>
        <p><b>Paste Cleanup properties:</b></p>
        <ul>
            <li>
                <p>prompt - specifies whether to enable the prompt when pasting in Rich Text Editor.</p>
            </li>
            <li>
                <p>plainText - specifies whether to paste as plain text or not in Rich Text Editor.</p>
            </li>
            <li>
                <p>keepFormat- specifies whether to keep or remove the format when pasting in Rich Text Editor.</p>
            </li>
            <li>
                <p>deniedTags - specifies the tags to restrict when pasting in Rich Text Editor.</p>
            </li>
            <li>
                <p>deniedAttributes - specifies the attributes to restrict when pasting in Rich Text Editor.</p>
            </li>
            <li>
                <p>allowedStyleProperties - specifies the allowed style properties when pasting in Rich Text Editor.</p>
            </li>
        </ul>";
            return View();
        }

    }