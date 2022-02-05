public ActionResult OpenMode()
{
    ViewBag.hover = "Tooltip from hover";
    ViewBag.click = "Tooltip from click";
    ViewBag.focus = "Tooltip from focus";
    ViewBag.custom = "Tooltip from custom mode";
    return View();
}