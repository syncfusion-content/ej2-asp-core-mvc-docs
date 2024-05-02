
        [AcceptVerbs("Post")]
        [HttpPost]
        public object Save(SaveSettings saveSettings)
        {
           
                return Workbook.Save(saveSettings);
           
        }
        [AcceptVerbs("Post")]
        [HttpPost]
        public IActionResult Open(IFormCollection openRequest)
        {
            OpenRequest open = new OpenRequest();
            open.File = openRequest.Files[0];
            return Content(Workbook.Open(open));
        }