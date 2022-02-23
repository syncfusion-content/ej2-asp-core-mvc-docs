public void Remove([FromBody]CRUDModel value)
{
    TreeData.tree.Remove(TreeData.tree.Where(ds => ds.TaskID == int.Parse(value.Key.ToString())).FirstOrDefault());
}

public ActionResult Delete(CRUDModel value)
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