using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2CoreSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public ActionResult Diagram()
        {
            // Define the nodes
            List<DiagramNode> nodes = new List<DiagramNode>
            {
                new DiagramNode
                {
                    Id = "288192",
                    OffsetX = 100,
                    OffsetY = 100,
                    Annotations = new List<DiagramNodeAnnotation>
                    {
                        new DiagramNodeAnnotation { Content = "SWGREM4-B" }
                    }
                },
                new DiagramNode
                {
                    Id = "288193",
                    ParentId = "288192",
                    OffsetX = 100,
                    OffsetY = 170,
                    Annotations = new List<DiagramNodeAnnotation>
                    {
                        new DiagramNodeAnnotation { Content = "ATS-EQ-1" }
                    }
                },
                new DiagramNode
                {
                    Id = "288198",
                    ParentId = "288192",
                    OffsetX = 100,
                    OffsetY = 240,
                    Annotations = new List<DiagramNodeAnnotation>
                    {
                        new DiagramNodeAnnotation { Content = "ATS-EQ-2" }
                    }
                }
            };

            // Generate connectors
            List<DiagramConnector> connectors = GenerateConnectors(nodes);

            ViewBag.nodes = nodes;
            ViewBag.connectors = connectors;

            // JavaScript logic for client-side behavior
            ViewBag.Script = @"
                document.addEventListener('DOMContentLoaded', function () {
                    var diagram = document.getElementById('diagram').ej2_instances[0];

                    function getNodeDefaults(node) {
                        node.width = 75;
                        node.height = 40;
                        return node;
                    }

                    function getConnectorDefaults(connector) {
                        connector.type = 'Orthogonal';
                        return connector;
                    }

                    diagram.getNodeDefaults = getNodeDefaults;
                    diagram.getConnectorDefaults = getConnectorDefaults;
                });
            ";

            return View();
        }

        private List<DiagramConnector> GenerateConnectors(List<DiagramNode> nodes)
        {
            List<DiagramConnector> connectors = new List<DiagramConnector>();
            int count = 1;

            foreach (var node in nodes)
            {
                var childNodes = CheckIfAnyChildExists(nodes, node.Id);
                foreach (var child in childNodes)
                {
                    connectors.Add(new DiagramConnector
                    {
                        Id = $"connector-{count}",
                        SourceID = node.Id,
                        TargetID = child.Id,
                        SourcePortID = $"portOut-{child.Id}",
                        TargetPortID = $"portIn-{child.Id}"
                    });
                    count++;
                }
            }

            return connectors;
        }

        private List<DiagramNode> CheckIfAnyChildExists(List<DiagramNode> nodes, string id)
        {
            List<DiagramNode> childNodes = new List<DiagramNode>();

            foreach (var node in nodes)
            {
                if (node.ParentId == id)
                {
                    childNodes.Add(node);
                }
            }

            return childNodes;
        }
    }
}