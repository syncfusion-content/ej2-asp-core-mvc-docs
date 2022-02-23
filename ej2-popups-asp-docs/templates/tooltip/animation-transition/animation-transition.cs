public ActionResult TooltipAnimation()
{
        ViewBag.animation = new
            {
                open = new { effect = "ZoomIn", duration = 500 },
                close = new { effect = "ZoomOut", duration = 500 }
            };
        return View();
}