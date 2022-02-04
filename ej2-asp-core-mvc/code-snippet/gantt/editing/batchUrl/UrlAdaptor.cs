  public class ICRUDModel<T> where T : class
        {

            public object key { get; set; }

            public T value { get; set; }

            public List<T> added { get; set; }

            public List<T> changed { get; set; }

            public List<T> deleted { get; set; }

        }
 public ActionResult BatchSave([FromBody]ICRUDModel<GanttData> data)
        {

            List<GanttData> uAdded = new List<GanttData>();
            List<GanttData> uChanged = new List<GanttData>();
            List<GanttData> uDeleted = new List<GanttData>();
            //...
             return Json(new { addedRecords = uAdded, changedRecords = uChanged, deletedRecords = uDeleted });
        }