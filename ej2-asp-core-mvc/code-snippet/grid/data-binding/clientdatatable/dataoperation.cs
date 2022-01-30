public IActionResult UrlDatasource([FromBody]DataManagerRequest dm)
{
    IEnumerable DataSource = Utils.DataTableToJson(dt); //Here dt is the dataTable
    DataOperations operation = new DataOperations();
    if (dm.Search != null && dm.Search.Count > 0)
    {
        DataSource = operation.PerformSearching(DataSource, dm.Search);  //Search
    }
    if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
    {
        DataSource = operation.PerformSorting(DataSource, dm.Sorted);
    }
    if (dm.Where != null && dm.Where.Count > 0) //Filtering
    {
        DataSource = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
    }
	List<string> str = new List<string>();
    if (dm.Aggregates != null)
    {           
        for (var i = 0; i < dm.Aggregates.Count; i++)
            str.Add(dm.Aggregates[i].Field);
    }
    IEnumerable aggregate = operation.PerformSelect(DataSource, str);
    int count = DataSource.Cast<object>().Count();
    if (dm.Skip != 0)
    {
        DataSource = operation.PerformSkip(DataSource, dm.Skip);   //Paging
    }
    if (dm.Take != 0)
    {
        DataSource = operation.PerformTake(DataSource, dm.Take);
    }
    return dm.RequiresCounts ? Json(new { result = DataSource, count = count, aggregate = aggregate }) : Json(DataSource);
}