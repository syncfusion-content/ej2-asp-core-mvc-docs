public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "CreateTable" };
        ViewBag.Table = new[] {
                "Tableheader", "TableRemove", "|", "TableRows", "TableColumns", "TableCell", "|" , "Styles", "BackgroundColor", "Alignments", "TableCellVerticalAlign"
            };
         ViewBag.value = @"<h2>Discover the Table's Powerful Features</h2><p>A table can be created in the editor using either a keyboard shortcut or the toolbar. With the quick
            toolbar, you can
            perform table cell insert, delete, split, and merge operations. You can style the table cells using
            background
            colours and borders.</p><table class='e-rte-table' style='width: 100%; min-width: 0px; height: 151px'>
            <thead>
                <tr>
                    <th><span>Name</span><br/></th>
                    <th><span>Age</span><br/></th>
                    <th><span>Gender</span><br/></th>
                    <th><span>Occupation</span><br/></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Selma Rose</td>
                    <td>30</td>
                    <td>Female</td>
                    <td><span>Engineer</span><br/></td>
                </tr>
                <tr>
                    <td><span>Robert</span><br/></td>
                    <td>28</td>
                    <td>Male</td>
                    <td><span>Graphic Designer</span></td>
                </tr>
                <tr>
                    <td><span>William</span><br/></td>
                    <td>35</td>
                    <td>Male</td>
                    <td>Teacher</td>
                </tr>
            </tbody>
        </table>";
        return View();
    }
}
