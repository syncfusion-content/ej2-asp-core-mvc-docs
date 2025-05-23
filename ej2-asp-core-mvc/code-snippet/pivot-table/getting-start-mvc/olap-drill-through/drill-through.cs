public ActionResult Index()
{
    ViewBag.filterMembers = new string[] { "[Date].[Fiscal].[Fiscal Quarter].&[2002]&[4]", "[Date].[Fiscal].[Fiscal Year].&[2005]" };
    return View();
}