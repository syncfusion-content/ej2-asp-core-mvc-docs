
// Local Data
public ActionResult LocalData()
{
    // For MenuFieldSettings type, include Syncfusion.EJ2.Navigations in the using directive section.
    MenuFieldSettings menuFields = new MenuFieldSettings()
    {
        Text = new string[] { "continent", "country", "language" },
        Children = new string[] { "countries", "languages" }
    };
    // Assign Local data from Model to ViewBag.menuItems
    ViewBag.menuItems = Model.GetLocalData();
    ViewBag.menuFields = menuFields;
    return View();
}