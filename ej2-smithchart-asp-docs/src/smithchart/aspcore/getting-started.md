---
title: "Getting Started"
component: "Smith Chart"
description: "Getting started in smith chart component"
---

# Getting Started with ASP.NET Core

This section explains you the steps required to create a Smithchart and demonstrate the basic usage of the Smithchart control.

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

![Alt text](./images/solution-Explorer.png)

Install the **Syncfusion.EJ2** package to the application

![Alt text](./images/nuget-demo.png)

After Installation complete this will included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as dependency since it **Syncfusion.EJ2** dependent to NewtonSoft.JSON package.

**Step 3:** Open the **_ViewImports.cshtml** to import Syncfusion.EJ2 package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **_Layout.cshtml.**

```cs
@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
```

**Step 5:** Adding Script Manager in layout page **_Layout.cshtml.**

```cs
<ejs-scripts></ejs-scripts>
```

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the smith chart.

```html

@using Syncfusion.EJ2;
 <ejs-smithchart id="smithchart">
</ejs-smithchart>

```

## Add series to Smith chart

The Smith chart has the following two type of specification for adding series:

* dataSource - Data object can be bound directly by specifying the resistance and reactance values.
* points - Collection of resistance and reactance values can be bound directly to render the series.

The following two ways demonstrate adding two series to the Smith chart.

* First series Transmission1 shows dataSource bound series.
* Second series Transmission2 shows points bound series.

{% aspTab template="smithchart/getting-started/series", sourceFiles="series.cs" %}

{% endaspTab %}

## Add title to SmithChart

smithchart `title` API used to add title for smithchart. In that `text` API used to set text of the title. API `visible` used to toggle the title.

{% aspTab template="smithchart/getting-started/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Enable marker to the Smith chart

To use marker in series and its customization in Smith chart, use series `marker` API. To display marker for a particular series, specify the `marker visible` to true. The following sample marker is enabled for the first series only.

{% aspTab template="smithchart/getting-started/marker", sourceFiles="marker.cs" %}

{% endaspTab %}

## Enable data label to marker

To use marker data label and its customization in Smith chart, use marker `dataLabel`. To display data label for a particular series marker, specify the `dataLabel visible` to true in that series `marker`. The following sample data label is enabled for the first series.

{% aspTab template="smithchart/getting-started/data-label", sourceFiles="data-label.cs" %}

{% endaspTab %}

## Enable legend for Smith chart

The legend feature is used to denote the corresponding series. You can enable the legend for the smithchart by setting the [`visible`]
property to true in [`legendSettings`] object. The following sample shows enabling legend for Smith chart. The series name can be customized using the series `name`.

{% aspTab template="smithchart/getting-started/legend", sourceFiles="legend.cs" %}

{% endaspTab %}

## Enable tooltip for the Smith chart series

The tooltip feature is used to show the values of the current point. You can enable tooltip by setting the [`visible`] property to true
in [`tooltipSettings`] object. The following sample shows enabling tooltip for Smith chart series collection.

{% aspTab template="smithchart/getting-started/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}
