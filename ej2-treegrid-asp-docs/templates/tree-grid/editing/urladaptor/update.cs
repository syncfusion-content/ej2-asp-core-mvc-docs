public ActionResult Update([FromBody]CRUDModel value)
{
    var val = TreeData.tree.Where(ds => ds.TaskID == value.Value.TaskID).FirstOrDefault();
    val.TaskName = value.Value.TaskName;
    val.StartDate = value.Value.StartDate;
    val.Duration = value.Value.Duration;
    val.Priority = value.Value.Priority;
    val.Progress = value.Value.Progress;
    return Json(val);            
}

public class CRUDModel
{
    public List<TreeData> Added { get; set; }

    public List<TreeData> Changed { get; set; }

    public List<TreeData> Deleted { get; set; }

    public TreeData Value;

    public int Key;

    public int? RelationalKey;
}