public ActionResult Default()
{
    List<object> fontData = new List<object>();
    fontData.Add(new { Text = "Arial" });
    fontData.Add(new { Text = "Serif" });
    fontData.Add(new { Text = "Sans-serif" });
    fontData.Add(new { Text = "Cursive" });
    fontData.Add(new { Text = "Fantasy" });
    ViewBag.data = fontData;

    List<object> sizeData = new List<object>();
    sizeData.Add(new { Text = "20" });
    sizeData.Add(new { Text = "30" });
    sizeData.Add(new { Text = "40" });
    sizeData.Add(new { Text = "50" });
    ViewBag.size = sizeData;
    
    return View();
}