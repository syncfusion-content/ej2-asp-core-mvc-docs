public IActionResult Index()
{
    ViewBag.toolBarItems = new String[] { "Pan", "Reset" };
    return View();
}