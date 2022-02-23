# Getting Started with ASP.NET Core

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

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the circulargauge.

## Render Default circulargauge

This section explains how to render default circulargauge.

```cs

public IActionResult Default()
{
    return View();
}

```

Add the `ejs-circulargauge` tag like below code snippet to create the default circulargauge.

```cs

@using Syncfusion.EJ2;

<ejs-circulargauge id="gauge">
</ejs-circulargauge>

```

## Add Gauge Title

You can add a title using `title` attribute to the circulargauge to provide quick information to the user.

```cs
@using Syncfusion.EJ2;

<ejs-circulargauge id="circular" title = 'Speed'>
</ejs-circulargauge>
```

## Axis

You can set the range to the axis using `minimum` and `maximum` attributes for axis tag.
Refer below code snippet to add the axis range to circulargauge.

```cs
<ejs-circulargauge id="circular">
    <e-circulargauge-axes>
    <e-circulargauge-axis startAngle="240" endAngle="120" minimum="0" maximum="120" radius="90%"></e-circulargauge-axis>
    </e-circulargauge-axes>
</ejs-circulargauge>
```