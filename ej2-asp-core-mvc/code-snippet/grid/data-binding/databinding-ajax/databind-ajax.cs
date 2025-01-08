
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;

namespace Grid_Columns.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {
        }
        public ActionResult OnPostGetdata()
        {
            IEnumerable DataSource = OrdersDetails.GetAllRecords();
            return new JsonResult(DataSource);
        }
        public ActionResult OnPostUpdate([FromBody] CRUDModel<OrdersDetails> value)
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
        public ActionResult OnPostInsert([FromBody] CRUDModel<OrdersDetails> value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value.value);
            return new JsonResult(value.value);
        }
        //Delete the record
        public ActionResult OnPostDelete(int key)
        {
            OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == key).FirstOrDefault());
            var data = OrdersDetails.GetAllRecords();
            return new JsonResult(data);
        }


    }

    public class CRUDModel<T> where T : class
    {
        public string action { get; set; }
        public string table { get; set; }
        public string keyColumn { get; set; }
        public object key { get; set; }
        public T value { get; set; }
        public List<T> added { get; set; }
        public List<T> changed { get; set; }
        public List<T> deleted { get; set; }
        public IDictionary<string, object> @params { get; set; }
    }
}
