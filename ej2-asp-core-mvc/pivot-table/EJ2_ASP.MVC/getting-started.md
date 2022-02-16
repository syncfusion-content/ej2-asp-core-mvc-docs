---
layout: post
title: Getting Started with ##Platform_Name## Pivot Table Component
description: Checkout and learn about getting started with ##Platform_Name## Pivot Table component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .NET Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Preparing ASP.NET MVC application

Follow below steps to create ASP.NET MVC Application.

**Step 1:** Choose **File > New > Project...** in the Visual Studio menu bar.

![new project in aspnetmvc5](images/new-mvc-project.png)

**Step 2:** Select **Installed > Visual C# > Web** and choose the required **.NET Framework** in the drop-down.

**Step 3:** Select **ASP.NET Web Application (.NET Framework)** and change the application name, and then click **OK**.

> The Essential JS 2 supports 4.5+ .NET Framework in the ASP.NET MVC application. i.e. The minimum target framework is 4.5 for Syncfusion ASP.NET MVC (Essential JS 2).

![aspnetmvc5 project template](images/aspnetmvc5-template.png)

**Step 4:** Choose **MVC** and then click **OK**. Now, the MVC web application project is created with default ASP.NET MVC template.

![aspnetmvc5 web application template](images/aspnetmvc5-config-template.png)

## Configure Essential JS 2 in the application

**Step 1:** Add the [`Syncfusion.EJ2.MVC5`](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5/) NuGet package to the new application by using the Nuget Package Manager. Right-click the project and select **Manage NuGet Packages...**.

> Refer to [this article](../../nuget-packages/) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

![aspnetmvc5 manage nuget packages](images/aspnetmvc5-manage-nuget.png)

**Step 2:** Search the `Syncfusion EJ2 MVC5` keyword in the **Browse** tab and install **Syncfusion.EJ2.MVC5** NuGet package in the application.

![aspnetmvc5 install nuget package](images/aspnetmvc5-nuget.png)

The Essential JS 2 MVC5 NuGet package will be included in the project, after the installation process is completed.

> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

**Step 3:** Open `~/Views/Web.config` file and add the `Syncfusion.EJ2` namesapce reference to the `<system.web.webPages.razor>` element and `Syncfusion.EJ2` assembly reference to `<system.web>` element.

```html
<configuration>
    ....
    ....
    <system.web.webPages.razor>
        ....
        ....
        <pages pageBaseType="System.Web.Mvc.WebViewPage">
            <namespaces>
                ....
                ....
                <add namespace="Syncfusion.EJ2"/>
            </namespaces>
        </pages>
    </system.web.webPages.razor>
    ....
    ....
    <system.web>
        <compilation>
            <assemblies>
                ....
                ....
                <add assembly="Syncfusion.EJ2, Culture=neutral" />
            </assemblies>
        </compilation>
    </system.web>
</configuration>
```

**Step 4:** Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn) in the `<head>` element of `~/Views/Shared/_Layout.cshtml` layout page.

```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
```

**Step 5:** Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        @Html.EJS().ScriptManager()
    </body>
```

## Browser compatibility

Polyfills are required to use the Pivot Table in Internet Explorer 11 browser. Refer the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/browser/?no-cache=1#browser-support) for more details.

## Adding component to the application

* Add the below code to your `Index.cshtml` view page which is present under `Views/Home` folder, to initialize the pivot table component.

* The Pivot Table component further needs to be populated with an appropriate data source. For illustration purpose, a collection of objects mentioning the sales details of certain products over a period and region has been prepared. This sample data is assigned to the pivot table component through [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/initial-pivot/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/initial-pivot/initial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/initial-pivot/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/initial-pivot/initial.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding fields to row, column, value and filter axes

Now that pivot table is initialized and assigned with sample data, will further move to showcase the component by organizing appropriate fields in row, column, value and filter axes.

In [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) class, four major axes -  [`Rows`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html), [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_Columns_System_Action_Syncfusion_EJ2_PivotView_PivotViewRowBuilder__), [`Values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_Values_System_Action_Syncfusion_EJ2_PivotView_PivotViewRowBuilder__) and [`Filters`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_Filters_System_Action_Syncfusion_EJ2_PivotView_PivotViewRowBuilder__) plays a vital role in defining and organizing fields from the bound data source, to render the entire pivot table component in a desired format.

[`Rows`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) – Collection of fields that needs to be displayed in row axis of the pivot table.

[`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_Columns_System_Action_Syncfusion_EJ2_PivotView_PivotViewRowBuilder__) – Collection of fields that needs to be displayed in column axis of the pivot table.

[`Values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_Values_System_Action_Syncfusion_EJ2_PivotView_PivotViewRowBuilder__) – Collection of fields that needs to be displayed as aggregated numeric values in the pivot table.

[`Filters`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_Filters_System_Action_Syncfusion_EJ2_PivotView_PivotViewRowBuilder__) - Collection of fields that would act as master filter over the data bound in row, column and value axes of the pivot table.

In-order to define each field in the respective axis, the following basic properties should be set.

* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Name): It allows to set the field name from the bound data source. It’s casing should match exactly like in the data source and if not set properly, the pivot table will not be rendered.
* [`Caption`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Caption): It allows to set the field caption, which is the alias name of the field that needs to be displayed in the pivot table.
* [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Type): It allows to set the summary type of the field. By default, [**SummaryTypes.Sum**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SummaryTypes.html) is applied.

In this illustration, "Year" and "Quarter" are added in column, "Country" and "Products" in row, and "Sold" and "Amount" in value section respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/add-fields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fields.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/add-fields/fields.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/add-fields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fields.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/add-fields/fields.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Applying formatting to a value field

Formatting defines a way in which values should be displayed. For example, format **"C"** denotes the values should be displayed in currency pattern. To do so, define the [`FormatSetting`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) class with its [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) and [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) properties and add it to [`PivotViewFormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html). In this illustration, the [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) property is set as **Amount**, a field from value section and its format is set as currency. Likewise, we can set format for other value fields as well and add it to [`PivotViewFormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html).

> Only fields from value section, which is in the form of numeric data values are applicable for formatting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Grouping Bar

The grouping bar feature automatically populates fields from the bound data source and allows end users to drag fields between different axes such as columns, rows, values, and filters, and alter pivot table at runtime. It also provides option to sort, filter and remove fields. It can be enabled by setting the [`ShowGroupingBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowGroupingBar) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Groupingbar.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/groupingbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Groupingbar.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/groupingbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Pivot Field List

The field list allows to add or remove fields and also rearrange the fields between different axes, including column, row, value, and filter along with filter and sort options dynamically at runtime. It can be enabled by setting the [`ShowFieldList`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Calculated field

The calculated field feature allows user to insert or add a new calculated field based on the available fields from the bound data source using basic arithmetic operators. The calculated field can be included in pivot table using the [`CalculatedFieldSetting`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html) class from code behind. Or else, calculated fields can be added at run time through the built-in dialog by just setting the [`AllowCalculatedField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowCalculatedField) property to **true** in pivot table. You will see a button enabled in the Field List UI automatically to invoke the calculated field dialog and perform necessary operation.

> Calculated field is applicable only for value fields.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/calculatedfield/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/calculatedfield/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/calculatedfield/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/calculatedfield/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](./images/pivotgrid-sample.png)

> You can refer to our [ASP.NET MVC Pivot Table](https://www.syncfusion.com/aspnet-mvc-ui-controls/pivot-table) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Pivot Table example](https://ej2.syncfusion.com/aspnetmvc/PivotTable/Default#/material) that shows how to rendering of the pivot table with drill-up and drill-down functionality bound to a relational report.