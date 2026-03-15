public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "CreateTable" };
        ViewBag.Table = new[] { "TableCellProperties"};
         ViewBag.value = @"<table class='e-rte-table' style='width: 100%; min-width: 0px; border-collapse: collapse;'>
    <colgroup>
        <col style='width: 40%;'>
        <col style='width: 60%;'>
    </colgroup>
    <thead>
        <tr>
            <th style='text-align: left; padding: 8px; border: 1px solid #dcdcdc;'>Property</th>
            <th style='text-align: left; padding: 8px; border: 1px solid #dcdcdc;'>Details</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Cell Width</td>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Specifies the width of the selected cell. Supports units such as <code>px</code>, <code>%</code>, or <code>auto</code>.</td>
        </tr>
        <tr>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Border</td>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Controls border style, color, and thickness for the cell to match design requirements.</td>
        </tr>
        <tr>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Cell Padding</td>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Adjusts internal spacing to improve readability and layout consistency.</td>
        </tr>
        <tr>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Alignment</td>
            <td style='padding: 8px; border: 1px solid #dcdcdc;'>Horizontal and vertical alignment options to position content within the cell.</td>
        </tr>
    </tbody>
 </table>
 <p><br/></p>";
        return View();
    }
}
