
GanttDataSourceEntities db = new GanttDataSourceEntities();     
public ActionResult BatchSave([FromBody]ICRUDModel<GanttData> data)
        {

           List<GanttData> uDeleted = new List<GanttData>();

            //Performing delete operation
            if (data.deleted != null && data.deleted.Count() > 0)
            {
                foreach (var rec in data.deleted)
                {
                    uDeleted.Add(this.Delete(rec.TaskId));
                }
            }
            return Json(new { deletedRecords = uDeleted });
        }
         public GanttData Delete(string value)
        {
            var result = db.GanttDatas.Where(currentData => currentData.TaskId == value).FirstOrDefault();
            db.GanttDatas.Remove(result);
            RemoveChildRecords(value);
            db.SaveChanges();
            return result;
        }
        public void RemoveChildRecords(string key)
        {
            var childList = db.GanttDatas.Where(x => x.ParentId == key).ToList();
            foreach (var item in childList)
            {
                db.GanttDatas.Remove(item);
                RemoveChildRecords(item.TaskId);
            }
        }