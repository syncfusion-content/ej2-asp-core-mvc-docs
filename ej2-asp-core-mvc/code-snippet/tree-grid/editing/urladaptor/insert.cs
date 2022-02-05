public void Insert([FromBody]ICRUDModel value)
{
    var i = 0;
    var index = value.rowIndex;
    for (; i < TreeData.tree.Count; i++)
    {
        if (TreeData.tree[i].TaskID == index)
        {
            break;
        }
    }
    i += FindChildRecords(index);
    TreeData.tree.Insert(i + 1, value.value);
}

public int FindChildRecords(int? id)
{
    var count = 0;
    for (var i = 0; i < TreeData.tree.Count; i++)
    {
        if (TreeData.tree[i].ParentItem == id)
        {
            count++;
            count += FindChildRecords(TreeData.tree[i].TaskID);
        }
    }
    return count;
}

public class CustomBind : TreeData
{
    public TreeData parentItem;
}

public class ICRUDModel
{
    public CustomBind value;
    public int key;
    public string action;
    public int? relationalKey;
}