public ActionResult TooltipAnimation()
{
    ViewBag.animation = new
    {
        open = new { effect = "ZoomIn", duration = 1000, delay = 0 },
        close = new { effect = "ZoomOut", duration = 500, delay = 0 }
    };
        return View();
}