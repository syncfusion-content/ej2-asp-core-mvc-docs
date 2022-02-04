using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DropDownTree.Models;
using Syncfusion.EJ2.DropDowns;

namespace DropDownTree.Controllers
{
    public class DropDownListController : Controller
    {
       public IActionResult RemoteData()
        {
            DropDownTreeFields childData = new DropDownTreeFields();
            childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
            childData.Value = "OrderID";
            childData.Text = "ShipName";
            childData.ParentValue = "EmployeeID";
            childData.DataSource = new Syncfusion.EJ2.DataManager
            {
                Url = "https://services.odata.org/V4/Northwind/Northwind.svc",
                Adaptor = "ODataV4Adaptor",
                CrossDomain = true
            };
            ViewBag.child = childData;
            return View();
        }
    }
}