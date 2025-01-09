      
public IActionResult Index()
{
    ViewBag.DataSource =OrderDetails.GetAllRecords();
    return View();
} 
public ActionResult OnPostEditPartial([FromBody] CRUDAction<DialogTemplateModel> value)
{
    ViewData["DataSource"] = OrdersDetails.GetAllRecords();
    return new PartialViewResult
    {
        ViewName = "_EditPartial",
        ViewData = new ViewDataDictionary<DialogTemplateModel>(ViewData, value.value)
    };
}
public ActionResult OnPostAddPartial()
{
    ViewData["DataSource"] = OrdersDetails.GetAllRecords();
    return new PartialViewResult
    {
        ViewName = "_AddPartial"
    };
}
public class CRUDAction<T> where T : class
{
    public string? action { get; set; }
    public string? table { get; set; }
    public string? keyColumn { get; set; }
    public object? key { get; set; }
    public T? value { get; set; }
    public List<T>? added { get; set; }
    public List<T>? changed { get; set; }
    public List<T>? deleted { get; set; }
    public IDictionary<string, object> @params { get; set; }

}