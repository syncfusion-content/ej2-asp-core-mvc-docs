GanttDataSourceEntities db = new GanttDataSourceEntities();    
 public ActionResult BatchUpdate(DataManagerRequest dm)
        {
          
            List<GanttData>DataList = db.GanttDatas.ToList();
            var count = DataList.Count();
            return Json(new { result = DataList, count = count });
        }