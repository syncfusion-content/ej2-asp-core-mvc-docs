using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.ComponentModel;
using Syncfusion.EJ2;
using Newtonsoft.Json;

namespace sample1.Controllers
{
    public class NodeController: Controller
    {
        // GET: Node
        public ActionResult Node()
        {
            // Sets the Annotation for the Node
            List<DiagramNode> Nodes = new List<DiagramNode>();
          
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation()
            {
                //Sets the offset for the content
                Content = "Node1",
                 Style = new DiagramTextStyle()
                {
                    Color = "black",
                    Fill = "transparent"
                },
            });
            List<stop> Stop = new List<stop>();
            Stop.Add(new stop() { Color = "white", Offset = 0 });
            Stop.Add(new stop() { Color = "#6BA5D7", Offset = 100 });
            linearGradient grade = new linearGradient()
            {
                x1 = 0,
                y1 = 0,
                x2 = 50,
                y2 = 50,
                type = GradientType.Linear,
                Stops = Stop
            };
            Nodes.Add(new DefaultNode()
            {
                Id = "Node1",
                OffsetY = 100,
                OffsetX = 100,
                Height = 100,
                Width = 100,
                Style = new NodeStyleNodes() { Gradient= grade },
                // add the Annotation for the Node
                Annotations = Node1,
            });
                     
            ViewBag.nodes = Nodes;         

            return View();
        }
    }
    public class linearGradient
    {
        [DefaultValue(null)]
        [HtmlAttributeName("x1")]
        [JsonProperty("x1")]
        public double x1
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("x2")]
        [JsonProperty("x2")]
        public double x2
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("y1")]
        [JsonProperty("y1")]
        public double y1
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("y2")]
        [JsonProperty("y2")]
        public double y2
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public GradientType type
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("stops")]
        [JsonProperty("stops")]
        public List<stop> Stops
        {
            get;
            set;
        }
    }

    public class stop
    {
        [DefaultValue(null)]
        [HtmlAttributeName("color")]
        [JsonProperty("color")]
        public string Color
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("offset")]
        [JsonProperty("offset")]
        public double Offset
        {
            get;
            set;
        }
    }
    }