using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using itemtemplates.Models;
using Syncfusion.EJ2.DropDowns;
using Syncfusion.EJ2;

namespace itemtemplates.Controllers
{
    public class HomeController : Controller
    {
        DropDownTreeFields parentData = new DropDownTreeFields();
        DropDownTreeFields childData = new DropDownTreeFields();
        public ActionResult Index()
        {            
            object data = new Syncfusion.EJ2.DataManager
                {
                    Url = "https://services.odata.org/V4/Northwind/Northwind.svs",
                    Adaptor = "ODataV4Adaptor",
                    CrossDomain = true
                };
                parentData.Query = "new ej.data.Query().from('Employees').select('EmployeeID,FirstName,Title').take(5)";
                parentData.Value = "EmployeeID";
                parentData.Text = "FirstName";
                parentData.HasChildren = "EmployeeID";
                parentData.Child = childData;
                parentData.DataSource = data; 
                childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
                childData.Value = "OrderID";
                childData.Text = "ShipName";
                childData.ParentValue = "EmployeeID";
                childData.DataSource = data;
                ViewBag.remoteFields = parentData;

                DropDownTreeFields childDatas = new DropDownTreeFields();
                childDatas.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
                childDatas.Value = "OrderID";
                childDatas.Text = "ShipName";
                childDatas.ParentValue = "EmployeeID";
                childDatas.DataSource = new DataManager
                {
                    Url = "https://services.odata.org/V4/Northwind/Northwind.svc",
                    Adaptor = "ODataV4Adaptor",
                    CrossDomain = true
                };
                ViewBag.child = childDatas;
                return View();
        }    
    }
}