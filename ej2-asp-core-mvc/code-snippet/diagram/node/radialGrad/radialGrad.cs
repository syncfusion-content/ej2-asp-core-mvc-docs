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
            radialGradient grade = new radialGradient()
            {
                cx = 50,
                cy = 50,
                fx = 25,
                fy = 25,
                r=50,
                type = GradientType.Radial,
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
    public class radialGradient
    {
        [DefaultValue(null)]
        [HtmlAttributeName("cx")]
        [JsonProperty("cx")]
        public double cx
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("fx")]
        [JsonProperty("fx")]
        public double fx
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("fy")]
        [JsonProperty("fy")]
        public double fy
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("cy")]
        [JsonProperty("cy")]
        public double cy
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
        [HtmlAttributeName("r")]
        [JsonProperty("r")]
        public double r
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