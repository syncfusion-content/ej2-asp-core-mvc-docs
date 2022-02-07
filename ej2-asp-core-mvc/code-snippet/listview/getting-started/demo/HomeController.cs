public IActionResult Index()
    {
            //define the array of JSON
            List<object> data = new List<object>();
            data.Add(new { text: "Artwork", id: "01" });
            data.Add(new { text: "Abstract", id: "02" });
            data.Add(new { text: "Modern Painting", id: "03" });
            data.Add(new { text: "Ceramics", id: "04" });
            data.Add(new { text: "Animation Art", id: "05" });
            data.Add(new { text: "Oil Painting", id: "06" });
            ViewBag.dataSource = data;
            return View();
    }