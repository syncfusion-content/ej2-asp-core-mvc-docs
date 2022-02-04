public ActionResult SplitTasks()
        {
            ViewBag.DataSource = GanttData.SplitTasksData();
            ViewBag.Segment = GanttData.SegmentData();
            return View();
        }