public JsonResult OnPostGetOrderData(){
    IEnumerable<OrdersDetails> dataSource = OrdersDetails.GetAllRecords();
    int totalCount = dataSource.Count();
    return new JsonResult(new { result = dataSource, count = totalCount });
}