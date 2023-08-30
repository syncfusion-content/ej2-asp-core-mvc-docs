using Syncfusion.EJ2.Navigations;

public ActionResult Index()
{
    List<MenuItem> companyMenuItems = new List<MenuItem>(){
        new MenuItem
        {
            Text = "Company",
            Items = new List<MenuItem>()
            {
                new MenuItem { Text= "About Us" },
                new MenuItem { Text= "Customers" },
                new MenuItem { Text= "Blog" },
                new MenuItem { Text= "Careers" }
            }
        }
    };
    ViewBag.CompanyMenuItems = companyMenuItems;
    List<MenuItem> productMenuItems = new List<MenuItem>(){
        new MenuItem
        {
            Text = "Products",
            Items = new List<MenuItem>()
            {
                new MenuItem { Text= "Developer" },
                new MenuItem { Text= "Analytics" },
                new MenuItem { Text= "Reporting" },
                new MenuItem { Text= "Help Desk" }
            }
        }
    };
    ViewBag.ProductMenuItems = productMenuItems;
    List<MenuItem> aboutMenuItems = new List<MenuItem>(){
        new MenuItem
        {
            Text = "About Us"
        }
    };
    ViewBag.AboutMenuItems = aboutMenuItems;
    List<MenuItem> carrerMenuItems = new List<MenuItem>(){
        new MenuItem
        {
            Text = "Carrers"
        }
    };
    ViewBag.CarrerMenuItems = carrerMenuItems;
    return View();
}