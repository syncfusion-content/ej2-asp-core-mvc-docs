
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Syncfusion.EJ2.Base;
using System.Collections;
using Grid_Columns.Models;

namespace Grid_Columns.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {
        }
        public JsonResult OnPostUrlDatasource([FromBody] DataManagerRequest dm)
        {
            IEnumerable DataSource = OrdersDetails.GetAllRecords();
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
            int count = DataSource.Cast<OrdersDetails>().Count();
            if (dm.Skip != 0)
            {
                DataSource = operation.PerformSkip(DataSource, dm.Skip); //Paging
            }
            if (dm.Take != 0)
            {
                DataSource = operation.PerformTake(DataSource, dm.Take);
            }
            return dm.RequiresCounts ? new JsonResult(new { result = DataSource, count = count }) : new JsonResult(DataSource);
        }
        public JsonResult OnPostGetdata()
        {
            IEnumerable DataSource = OrdersDetails.GetAllRecords();
            return new JsonResult(DataSource);
        }
        public JsonResult OnPostUpdate([FromBody] CRUDModel<OrdersDetails> value)
        {
            var ord = value.value;
            OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            val.ShipCountry = ord.ShipCountry;
            return new JsonResult(value.value);
        }
        //insert the record
        public JsonResult OnPostInsert([FromBody] CRUDModel<OrdersDetails> value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value.value);
            return new JsonResult(value.value);
        }
        //Delete the record
        public JsonResult OnPostDelete([FromBody] CRUDModel<OrdersDetails> value)
        {
            OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == int.Parse(value.key.ToString())).FirstOrDefault());

            return new JsonResult(value);
        }
    }
    public class CRUDModel<T> where T : class
    {

        public string? action { get; set; }

        public string? keyColumn { get; set; }

        public object? key { get; set; }

        public T? value { get; set; }

        public List<T>? added { get; set; }

        public List<T>? changed { get; set; }

        public List<T>? deleted { get; set; }

        public IDictionary<string, object>? @params { get; set; }
    }
}
