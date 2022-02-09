using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;
using Syncfusion.EJ2.Charts;
using Syncfusion.EJ2.LinearGauge;


namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("FullName");
            dt.Columns.Add("Stock");
            dt.Columns.Add("MaxStock");
            dt.Columns.Add("FreeStock");
            dt.Columns.Add("AvailableStock");
            dt.Columns.Add("StockCode");
            dt.Columns.Add("Status");
            dt.Rows.Add(new Object[] { "T13", "PM01 T13", 5000, 10000, 5000, 8230, "F" });
            dt.Rows.Add(new Object[] { "T14", "PM01 T14", 4000, 9000, 5000, 7230, "F" });
            dt.Rows.Add(new Object[] { "T15", "PM01 T15", 3000, 8000, 5000, 5230, "F" });
            dt.Rows.Add(new Object[] { "T16", "PM01 T16", 2000, 7000, 5000, 5230, "F" });

            List<LinearData> gauges = new List<LinearData>();

            foreach (DataRow row in dt.Rows)
                gauges.Add(CreateLinearGauge(row));

            ViewBag.GaugeData = gauges;
            return View();
        }
        [HttpPost]
        public ActionResult GetServerData()
        {
            List<pointData> data1 = new List<pointData>();
            data1.Add(new pointData(5600));
            data1.Add(new pointData(5700));
            data1.Add(new pointData(6700));
            data1.Add(new pointData(6700));
            return Json(data1);
        }

        LinearData CreateLinearGauge(DataRow row)
        {
                        
            double minimum = Convert.ToDouble(row["FreeStock"]);
            double maximum = Convert.ToDouble(row["MaxStock"]);
            double value = Convert.ToDouble(row["AvailableStock"]);
            return new LinearData() { Minimum = minimum, Maximum = maximum, Value = value };
        }
    }
    public class pointData
    {
        public pointData(double value)
        {
            this.value = value;
        }
        public double value { get; set; }
    }
    public class LinearData
    {
        public double Minimum { get; set; }
        public double Maximum { get; set; }
        public double Value { get; set; }
    }
}
