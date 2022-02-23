GanttDataSourceEntities db = new GanttDataSourceEntities();     
public ActionResult BatchSave([FromBody]ICRUDModel<GanttData> data)
        {

            List<GanttData> uChanged = new List<GanttData>();

            //Performing update operation
            if (data.changed != null && data.changed.Count() > 0)
            {
                foreach (var rec in data.changed)
                {
                    uChanged.Add(this.Edit(rec));
                }
            }
             return Json(new { changedRecords = uChanged });
            //...
        }
         public GanttData Edit(GanttData value)
        {
            GanttData result = db.GanttDatas.Where(currentData => currentData.TaskId == value.TaskId).FirstOrDefault();
            if (result != null)
            {
                result.TaskId = value.TaskId;
                result.TaskName = value.TaskName;
                result.StartDate = value.StartDate;
                result.EndDate = value.EndDate;
                result.Duration = value.Duration;
                result.Progress = value.Progress;
                result.Predecessor = value.Predecessor;
                db.SaveChanges();
                return result;
            }
            else
            {
                return null;
            }
        }