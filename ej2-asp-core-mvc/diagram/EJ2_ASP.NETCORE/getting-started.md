---
layout: post
title: Getting Started with Syncfusion ##Platform_Name## Diagram Control
description: Checkout and learn about getting started with ##Platform_Name## Diagram control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Diagram Control

This section briefly explains about how to include [ASP.NET Core Diagram](https://www.syncfusion.com/aspnet-core-ui-controls/diagram) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.  Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-script>` at the end of `<body>` in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Diagram control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Diagram tag helper in `~/Pages/Index.cshtml` page. Create and add a `node` (JSON data) with specific position, size, label, and shape.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/node/tagHelper %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Diagram control will be rendered in the default web browser.

![ASP.NET Core Diagram Control](images/diagram-control.png)

## Connect two Nodes with a Connector

Add two nodes to the diagram as shown in the previous example. Connect these nodes by adding a connector using the `connector` property and refer the source and target end by using the `sourceNode` and `targetNode` properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/connector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/diagram/getting-started/connector/connector.cs %}
{% endhighlight %}
{% endtabs %}

![Connection between two Nodes in ASP.NET Core Diagram](images/diagram-with-nodes-connector.png)

## Adding default values

Default values for all `nodes` and `connectors` can be set using the `getNodeDefaults` and `getConnectorDefaults` properties, respectively. For example, if all nodes have the same width and height, such properties can be moved into `getNodeDefaults`.

For example, if all the nodes have same `height` and `width`, set such properties as follows.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/defaultvalues/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Defaultvalues.cs" %}
{% include code-snippet/diagram/getting-started/defaultvalues/defaultvalues.cs %}
{% endhighlight %}
{% endtabs %}

## Flow Diagram

Similarly, the required nodes and connectors can be added to form a complete flow diagram.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/getting-started/flowchart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Flowchart.cs" %}
{% include code-snippet/diagram/getting-started/flowchart/flowchart.cs %}
{% endhighlight %}
{% endtabs %}

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

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Diagram/ASP.NET%20Core%20Tag%20Helper%20Examples).