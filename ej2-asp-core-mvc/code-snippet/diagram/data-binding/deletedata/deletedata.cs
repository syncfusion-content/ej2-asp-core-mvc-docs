using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: LocalData
        public IActionResult LocalData()
        {
             CRUDAction nodeCrud = new CRUDAction()
            {
                //Define URL to perform CRUD operations with nodes records in database.
                Destroy = "https://js.syncfusion.com/demos/ejServices/api/Diagram/DeleteNodes",
            };

            ViewBag.NodeCrud = nodeCrud;


            ConnectionDataSource dataSource = new ConnectionDataSource()
            {
                Id = "Name",
                SourceID = "SourceNode",
                TargetID = "TargetNode",
                CrudAction = new CRUDAction()
                {
                    //Define URL to perform CRUD operations with connector records in database.
                    Destroy = "https://js.syncfusion.com/demos/ejServices/api/Diagram/DeleteConnectors",
                }
            };
            ViewBag.DataSource = dataSource;
            return View();
        }
    }
   public class CRUDAction
    {
        [DefaultValue(null)]
        [HtmlAttributeName("read")]
        [JsonProperty("read")]
        public string Read { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("create")]
        [JsonProperty("create")]
        public string Create { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("update")]
        [JsonProperty("update")]
        public string Update { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("destroy")]
        [JsonProperty("destroy")]
        public string Destroy { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("customFields")]
        [JsonProperty("customFields")]
        public object[] CustomFields { get; set; }
    }

    public class ConnectionDataSource
    {
        [DefaultValue(null)]
        [HtmlAttributeName("id")]
        [JsonProperty("id")]
        public string Id { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("sourceID")]
        [JsonProperty("sourceID")]
        public string SourceID { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("targetID")]
        [JsonProperty("targetID")]
        public string TargetID { get; set; }

        [DefaultValue(null)]
        [HtmlAttributeName("crudAction")]
        [JsonProperty("crudAction")]
        public CRUDAction CrudAction { get; set; }
    }
}