public ActionResult Index(DataManager dm)
{
   var data = TreeData.GetTree();
   ViewBag.dataSource = data;
   return View();
}

public ActionResult Insert([FromBody]CRUDModel value)
{
    var i = 0;
    for (; i < TreeData.tree.Count; i++)
    {
        if (TreeData.tree[i].TaskID == value.RelationalKey)
        {
            break;
        }
    }
    i += FindChildRecords(value.RelationalKey);  // Finds Inserted new record index when newRowPosition API is in "Below".
    TreeData.tree.Insert(i + 1, value.Value);
    return Json(value.Value);
}

public int FindChildRecords(int? id)
{
    var count = 0;
    for (var i = 0; i < TreeData.tree.Count; i++)
    {
        if (TreeData.tree[i].ParentID == id)
        {
            count++;
            count += FindChildRecords(TreeData.tree[i].TaskID);
        }
    }
    return count;
}

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

public void Remove([FromBody]CRUDModel value)
{
    TreeData.tree.Remove(TreeData.tree.Where(ds => ds.TaskID == int.Parse(value.Key.ToString())).FirstOrDefault());
}

public ActionResult Delete([FromBody]CRUDModel value)
{
    if (value.Deleted != null) 
    {
       for (var i = 0; i < value.Deleted.Count().Count; i++)
        {
            TreeData.tree.Remove(TreeData.tree.Where(ds => ds.TaskID == value.Deleted[i].TaskID).FirstOrDefault());
        }
    }
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