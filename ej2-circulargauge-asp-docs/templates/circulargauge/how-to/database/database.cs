using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Initialize the chart model 
            CircularGauge gaugeModel = new CircularGauge();           
            // Add the required properties for chart using the following method
            InitializeGauge(gaugeModel);
            // Store the chart model 
            ViewData["GaugeModel"] = gaugeModel;
            return View();
        }
        private void InitializeGauge(CircularGauge gaugeModel)
        {
            // Create a data base data table
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("MaxStock");
            dt.Columns.Add("FreeStock");
            dt.Columns.Add("AvailableStock");
            dt.Rows.Add(new Object[] { "T13", 10000, 5000, 8230 });

            // Create  a new data collection from data base table
            GaugeData gauges = new GaugeData();
            foreach (DataRow row in dt.Rows)
            {
                gauges.Minimum = Convert.ToDouble(row["FreeStock"]);
                gauges.Maximum = Convert.ToDouble(row["MaxStock"]);
                gauges.Value = Convert.ToDouble(row["AvailableStock"]);
            }

            CircularGaugePointer pointer = new CircularGaugePointer();
            pointer.Value = gauges.Value;

            CircularGaugeAxis axis = new CircularGaugeAxis();
            axis.Pointers = new List<CircularGaugePointer>();
            axis.Minimum = gauges.Minimum;
            axis.Maximum = gauges.Maximum;
            axis.Pointers.Add(pointer);

            gaugeModel.Axes = new List<CircularGaugeAxis>();
            gaugeModel.Axes.Add(axis);
        }
    }
    public class GaugeData
    {
        public double Minimum;
        public double Maximum;
        public double Value;
    }
}