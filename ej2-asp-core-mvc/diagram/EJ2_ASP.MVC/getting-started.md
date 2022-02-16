---
layout: post
title: Getting Started with ##Platform_Name## Diagram Component
description: Checkout and learn about getting started with ##Platform_Name## Diagram component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get start with ASP.NET Core application, need to ensure the following software to be installed on the machine.
* Visual Studio 2017
* DotNet Core 2.0

## Setup ASP.NET Core application with Essential JS 2 for ASP.NET Core

The following steps to create ASP.NET Core Application.

**Step 1:** Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![Alt text](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using Nugget Package Manager.

Open the `nuGet` package manager.

![Alt text](./images/solution-explorer-core.png)

Install the **Syncfusion.EJ2** package to the application

![Alt text](./images/nuget-demo.png)

After Installation complete this will included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as dependency since it **Syncfusion.EJ2** dependent to NewtonSoft.JSON package.

**Step 3:** Open the **Views/_ViewImports.cshtml** to import Syncfusion.EJ2 package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **Views/Shared/_Layout.cshtml.**

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

**Step 5:** Adding Script Manager in layout page **Views/Shared/_Layout.cshtml.**

```cs
<body>
    @RenderBody()
    @RenderSection("Scripts", required: false)
<ejs-scripts></ejs-scripts>
</body>
```

## Create and Add Node

Create and add a `node` (JSON data) with specific position, size, label, and shape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/getting-started/node/node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/node/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/getting-started/node/node.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Connect two Nodes with a Connector

Add two node to the diagram as shown in the previous example. Connect these nodes by adding a connector using the `connector` property and refer the source and target end by using the `sourceNode` and `targetNode` properties.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/connector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/diagram/getting-started/connector/connector.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/connector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/diagram/getting-started/connector/connector.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding default values

Default values for all `nodes` and `connectors` can be set using the `getNodeDefaults` and `getConnectorDefaults` properties, respectively. For example, if all nodes have the same width and height, such properties can be moved into `getNodeDefaults`.

For example, if all the nodes have same `height` and `width`, we can set such properties as follows.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/defaultvalues/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Defaultvalues.cs" %}
{% include code-snippet/diagram/getting-started/defaultvalues/defaultvalues.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/defaultvalues/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Defaultvalues.cs" %}
{% include code-snippet/diagram/getting-started/defaultvalues/defaultvalues.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Flow Diagram

Similarly, the required nodes and connectors can be added to form a complete flow diagram.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/flowchart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Flowchart.cs" %}
{% include code-snippet/diagram/getting-started/flowchart/flowchart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/flowchart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Flowchart.cs" %}
{% include code-snippet/diagram/getting-started/flowchart/flowchart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

You can configure the above "Employee Information" with diagram, so that the nodes and connectors are automatically generated using the mapping properties. The following code example show how `dataSourceSettings` is used to map ID and parent with property name identifiers for employee information.

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

The following code examples indicate how to define the default appearance of nodes and connectors. The `setNodeTemplate` is used to update each node based on employee data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/orgchart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orgchart.cs" %}
{% include code-snippet/diagram/getting-started/orgchart/orgchart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/orgchart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Orgchart.cs" %}
{% include code-snippet/diagram/getting-started/orgchart/orgchart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [ASP.NET MVC Diagram](https://www.syncfusion.com/aspnet-mvc-ui-controls/diagram) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Diagram example](https://ej2.syncfusion.com/aspnetmvc/Diagram/DefaultFunctionalities#/material) that shows how to render the Diagram in ASP.NET MVC.