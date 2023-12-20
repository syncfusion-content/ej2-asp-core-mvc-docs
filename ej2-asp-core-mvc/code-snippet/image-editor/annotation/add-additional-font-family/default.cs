using Syncfusion.EJ2.ImageEditor;

public ActionResult Default()
{
    ImageEditorFontFamily fontFamily = new ImageEditorFontFamily { Default = "Arial", 
        Items = new object[] {
            new { id = "arial", text = "Arial" },
            new { id = "brush script mt", text = "Brush Script MT" },
            new { id = "papyrus", text = "Papyrus" },
            new { id = "times new roman", text = "Times New Roman" },
            new { id = "courier new", text = "Courier New" }
        }
    };
    ViewBag.fontFamily = fontFamily;
    return View();
}