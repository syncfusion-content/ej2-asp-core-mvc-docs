public ActionResult SplitTasks()
        {
            ViewBag.DataSource = GanttData.SplitTasksData();
            return View();
        }