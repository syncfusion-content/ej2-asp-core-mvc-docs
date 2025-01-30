---
layout: post
title: Getting Started with Syncfusion® ##Platform_Name## Diagram Control
description: Checkout and learn about getting started with ##Platform_Name## Diagram control of Syncfusion Essential® JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with Layout

This section briefly explains about how to include [ASP.NET Core Diagram](https://www.syncfusion.com/aspnet-core-ui-controls/diagram) control with Layout in your ASP.NET Core application.

## Automatic Organization Chart

In the 'Flow Diagram' section, how to create a diagram manually was discussed. This section explains how to create and position the diagram automatically.

### Business object (Employee information)

Define Employee Information as JSON data. The following code example shows an employee array whose, `Name` is used as an unique identifier and `ReportingPerson` is used to identify the person to whom an employee report to, in the organization.

```cs
    public data: Object[] = [
        {
            Name: "Elizabeth",
            Role: "Director"
        },
        {
            Name: "Christina",
            ReportingPerson: "Elizabeth",
            Role: "Manager"
        },
        {
            Name: "Yoshi",
            ReportingPerson: "Christina",
            Role: "Lead"
        },
        {
            Name: "Philip",
            ReportingPerson: "Christina",
            Role: "Lead"
        },
        {
            Name: "Yang",
            ReportingPerson: "Elizabeth",
            Role: "Manager"
        },
        {
            Name: "Roland",
            ReportingPerson: "Yang",
            Role: "Lead"
        },
        {
            Name: "Yvonne",
            ReportingPerson: "Yang",
            Role: "Lead"
        }
    ];
```

## Map data source

You can configure the above "Employee Information" with diagram, so that the nodes and connectors are automatically generated using the mapping properties. The following code example shows how `dataSourceSettings` is used to map ID and parent with property name identifiers for employee information.

```cs

<ejs-diagram id="diagram" width="100%" height="550px" getNodeDefaults="@ViewBag.getNodeDefaults" getConnectorDefaults="@ViewBag.getConnectorDefaults" created="diagramCreated">
                <e-diagram-datasourcesettings id="Id" parentId="ReportingPerson" dataManager="new DataManager(){ Data = (List<OverviewData>)ViewBag.Nodes }"></e-diagram-datasourcesettings>
                <e-diagram-layout type="OrganizationalChart"></e-diagram-layout>
                </ejs-diagram>
            function getNodeDefaults(obj, diagram) {
            obj.height = 60;
            obj.width = 100;
            return obj;
        }
        function getConnectorDefaults(connector, diagram) {
            connector.type = 'Orthogonal';
            return connector;
        }
        public partial class DiagramController : Controller
    {
        // GET: Overview
        public ActionResult Overview()
        {
           ViewBag.Nodes = OverviewData.GetAllRecords();
            return View();
        }
    }
    public class OverviewData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ReportingPerson { get; set; }
        public OverviewData(string id, string name, string designation, string reportingperson)
        {
            this.Id = id;
            this.Name =name;
            this.Designation =designation;
            this.ReportingPerson =reportingperson;
        }
        public static List<OverviewData> GetAllRecords()
        {
            List<OverviewData> data = new List<OverviewData>();
            data.Add(new OverviewData("parent", "Elizabeth", "Director", "" ));
            data.Add(new OverviewData("1", "Christina", "Manager", "parent"));
            data.Add(new OverviewData("2", "Yoshi", "Lead", "1" ));
            data.Add(new OverviewData("3", "Philip", "Lead", "1"));
            data.Add(new OverviewData("4", "Yang", "Manager", "parent"));
            data.Add(new OverviewData("5", "Roland", "Lead", "4"));
            data.Add(new OverviewData("6", "Yvonne", "Lead", "4"));
            return data;

        }
    }
```

## Visualize employee

The following code examples indicates how to define the default appearance of nodes and connectors. The `setNodeTemplate` is used to update each node based on employee data.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/orgchart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orgchart.cs" %}
{% include code-snippet/diagram/getting-started/orgchart/orgchart.cs %}
{% endhighlight %}
{% endtabs %}