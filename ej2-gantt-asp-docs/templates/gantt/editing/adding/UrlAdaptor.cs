GanttDataSourceEntities db = new GanttDataSourceEntities();     
public ActionResult BatchSave([FromBody]ICRUDModel<GanttData> data)
        {

            List<GanttData> uAdded = new List<GanttData>();

            //Performing insert operation
            if (data.added != null && data.added.Count() > 0)
            {
                foreach (var rec in data.added)
                {
                    uAdded.Add(this.Create(rec));
                }
            }
            return Json(new { addedRecords = uAdded });
            //...
        }
          public GanttData Create(GanttData value)
        {
            db.GanttDatas.Add(value);
            db.SaveChanges();
            return value;
        }