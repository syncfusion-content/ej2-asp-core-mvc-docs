# Compatibility with Syncfusion ASP.NET Core (Essential JS 1)

This documentation explains how to render  Essential JS 1 and Essential JS 2 Syncfusion components in a single page.

## Adding application

You can create Essential JS 1 and Essential JS 2 controls using the following links:

Getting started for [`EJ2 ASPNET Core control`](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core/)

Getting started for [`EJ1 ASPNET Core control`](https://help.syncfusion.com/aspnet-core/grid/getting-started)

## Style compatibility

Add compatibility styles. Essential JS 1 and Essential JS 2 controls have compatibility styles that do not affect each other.

```html
<head>
    @* Syncfusion Essential JS 1 Styles *@
    <link href="https://cdn.syncfusion.com/16.4.0.52/js/web/bootstrap-theme/ej.web.all.compatibility.min.css"  rel="stylesheet"/>
    @* Syncfusion Essential JS 2 Styles *@
    <link href="https://cdn.syncfusion.com/ej2/styles/compatibility/material.css" rel="stylesheet" />
</head>
```

## Script compatibility

Add scripts for Essential JS 1 and Essential JS 2 as shown in the following codes

```html
    @* Syncfusion Essential JS 1 Scripts *@
    <script src="~/lib/jquery/dist/jquery.js"></script>
    <script src="http://cdn.syncfusion.com/js/assets/external/jsrender.min.js"></script>
    <script src="http://cdn.syncfusion.com/16.4.0.52/js/web/ej.web.all.min.js"></script>

    @* Syncfusion Essential JS 2 Scripts *@
    <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
```

Note: If you do not add ej1 script before ej2 script, it will throw script error.

## Adding compatibility

To add compatibility, use the following code in the _Layout.cshtml page. Since EJ1 and EJ2 controls have same library names to perform different actions, conflicts may occur when you refer these both controls in same application. To overcome this, extend these libraries in ej namespace.

```html
<script>
    var dataCopy = Object.assign({}, ej.data);
    $.extend(ej, Syncfusion);
    $.extend(ej.data, dataCopy);
</script>
```

## Adding script manager

Define script manager for both Essential JS 1 and Essential JS 2:

```html
    <ej-script-manager></ej-script-manager>
    <ejs-scripts></ejs-scripts>
```

The following code illustrates the final view of layout page.

```html
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    @* Syncfusion Essential JS 1 Styles *@
    <link href="https://cdn.syncfusion.com/16.4.0.52/js/web/bootstrap-theme/ej.web.all.compatibility.min.css"  rel="stylesheet"/>
    @* Syncfusion Essential JS 2 Styles *@
    <link href="https://cdn.syncfusion.com/ej2/styles/compatibility/material.css" rel="stylesheet" />

    @* Syncfusion Essential JS 1 Scripts *@
    <script src="~/lib/jquery/dist/jquery.js"></script>
    <script src="http://cdn.syncfusion.com/js/assets/external/jsrender.min.js"></script>
    <script src="http://cdn.syncfusion.com/16.4.0.52/js/web/ej.web.all.min.js"></script>

    @* Syncfusion Essential JS 2 Scripts *@
    <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>

<body>

    <script>
        var dataCopy = Object.assign({}, ej.data);
        $.extend(ej, Syncfusion);
        $.extend(ej.data, dataCopy);
    </script>
     
    <ej-script-manager></ej-script-manager>
    <ejs-scripts></ejs-scripts>

    <div class="container body-content">
        @RenderBody()
    </div>

</body>
</html>
```

## Declare Essential JS 1 and Essential JS 2 controls

Essential JS 1 and Essential JS 2 controls have already been initialized via getting started. If you want change control, you can initialize using the following code.

```html

<h2> Essential JS 1 - Grid Control</h2>

<ej-grid id="FlatGrid" datasource="ViewBag.Datasource" allow-paging="true">
    <e-columns>
        <e-column field="OrderID" header-text="Order ID" text-align="Right" width="70"></e-column>
        <e-column field="CustomerID" header-text="Customer ID" width="80"></e-column>
        <e-column field="EmployeeID" header-text="Employee ID" text-align="Left" width="75"></e-column>
        <e-column field="Freight" header-text="Freight" text-align="Right" format="{0:C2}" width="75"></e-column>
        <e-column field="ShipCity" header-text="Ship City" width="110"></e-column>
    </e-columns>
</ej-grid>

<h2> Essential JS 2 - Grid Component </h2>

<ejs-grid id="Grid" dataSource=@ViewBag.DataSource allowPaging="true">

    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" textAlign="Right" width="70"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer Name" width="80"></e-grid-column>
        <e-grid-column field="EmployeeID" headerText="Employee ID" textAlign="Left" width="75"></e-grid-column>
        <e-grid-column field="Freight" headerText="Freight" textAlign="Right" format="C2" width="75"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="110"></e-grid-column>
    </e-grid-columns>

</ejs-grid>

```

## Sample

https://github.com/SyncfusionExamples/ej2-aspcore-ej1compatibility