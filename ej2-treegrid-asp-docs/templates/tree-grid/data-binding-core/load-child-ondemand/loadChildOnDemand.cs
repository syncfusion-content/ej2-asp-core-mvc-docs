public IActionResult Index()
{
    return View();
}
public IActionResult DataSource([FromBody] DataManagerRequest dm)
{
    IEnumerable DataSource = TreeData.GetTree();
    DataOperations operation = new DataOperations();
    if (dm.Where != null && dm.Where.Count > 0) //filtering
    {
        DataSource = operation.PerformFiltering(DataSource, dm.Where, "and"); //perform filtering
    }
    if (dm.Sorted != null && dm.Sorted.Count > 0)
    {
		DataSource = operation.PerformSorting(DataSource, dm.Sorted);  //Sorting
    }
    var count = TreeData.GetTree().Count();
    if (dm.Skip != 0)
    {
        DataSource = operation.PerformSkip(DataSource, dm.Skip);   //Paging
    }
    if (dm.Take != 0)
    {
        DataSource = operation.PerformTake(DataSource, dm.Take);
    }

    if (dm.Where != null)
    {
        DataSource = CollectChildRecords(DataSource, dm); // method to collect child records
    }
    return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource);

 }

public IEnumerable CollectChildRecords(IEnumerable datasource, [FromBody] DataManagerRequest dm)
{
    DataOperations operation = new DataOperations();
    IEnumerable DataSource = TreeData.tree;  // use the total DataSource here 
    string IdMapping = "TaskID";     // define your IdMapping field name here 
    int[] TaskIds = new int[0];
    foreach (var rec in datasource)
    {
       int taskid = (int)rec.GetType().GetProperty(IdMapping).GetValue(rec);
       TaskIds = TaskIds.Concat(new int[] { taskid }).ToArray();       //get the Parentrecord Ids based on IdMapping Field
    }
    IEnumerable ChildRecords = null;
    foreach (int id in TaskIds)
    {
        dm.Where[0].value = id;
        IEnumerable records = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);   //perform filtering to collect the childrecords based on Ids
        ChildRecords = ChildRecords == null || (ChildRecords.AsQueryable().Count() == 0) ? records : ((IEnumerable<object>)ChildRecords).Concat((IEnumerable<object>)records);   //concate the childrecords with dataSource
    }
    if (ChildRecords != null)
    {
        ChildRecords = CollectChildRecords(ChildRecords, dm);     // repeat the operation for inner level child
        if (dm.Sorted != null && dm.Sorted.Count > 0) // perform Sorting
        {
           ChildRecords = operation.PerformSorting(ChildRecords, dm.Sorted);
        }
       datasource = ((IEnumerable<object>)datasource).Concat((IEnumerable<object>)ChildRecords);  //concate the childrecords with dataSource
    }
    return datasource;
}       