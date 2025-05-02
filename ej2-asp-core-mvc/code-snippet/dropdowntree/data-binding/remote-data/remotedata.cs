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
       public ActionResult RemoteData()
        {
            DropDownTreeFields parentData = new DropDownTreeFields();
            DropDownTreeFields childData = new DropDownTreeFields();
            object data = new DataManager
            {
                Url = "https://services.odata.org/V4/Northwind/Northwind.svc",
                Adaptor = "ODataV4Adaptor",
                CrossDomain = true
            };
            // Parent data mapping
            parentData.Query = "new ej.data.Query().from('Employees').select('EmployeeID,FirstName,Title').take(5)";
            parentData.Value = "EmployeeID";
            parentData.Text = "FirstName";
            parentData.HasChildren = "EmployeeID";
            parentData.Child = childData;
            parentData.DataSource = data;
            // Child data mapping  
            childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
            childData.Value = "OrderID";
            childData.Text = "ShipName";
            childData.ParentValue = "EmployeeID";
            childData.DataSource = data;
            ViewBag.remoteFields = parentData;
            return View();
        }
    }
}