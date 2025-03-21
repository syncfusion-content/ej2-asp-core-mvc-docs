---
layout: post
title: Olap in ##Platform_Name## Pivot Table component | Syncfusion
description: Learn here all about Olap in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Olap
publishingplatform: ##Platform_Name##
documentation: ug
---

# OLAP in ##Platform_Name## Pivot Table component

## Getting Started with ASP.NET Core

N> Starting with v16.2.0.x, if you reference Syncfusion<sup style="font-size:70%">&reg;</sup> assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion<sup style="font-size:70%">&reg;</sup> license key in your ASP.NET MVC application to use our components.

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 2.x application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?tabs=netcore2x).

### Create ASP.NET Core web application

**Step 1:** Choose **File > New > Project...** in the Visual Studio menu bar.

![new project in aspnetcore2.x](images/new-project.png)

**Step 2:** Select **Installed > Visual C# > .NET Core** and choose the required **.NET Framework** in the drop-down.

**Step 3:** Select **ASP.NET Core Web Application** and change the application name, and then click **OK**.

![aspnetcore2.x project template](images/aspnetcore2x-template.png)

**Step 4:** Choose **.NET Core** with **ASP.NET Core 2.0** and select **Web Application(Model-View-Controller)**, and then click **OK**. The web application project is now created with default ASP.NET Core template.

![aspnetcore2.x web application template](images/aspnetcore2x-netcore.png)

### Configure Essential<sup style="font-size:70%">&reg;</sup> JS 2 in the application

**Step 1:** Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new application by using the Nuget Package Manager. Right-click the project and select **Manage NuGet Packages...**.

N> Refer to [this article](../nuget-packages) to learn more details about installing Essential<sup style="font-size:70%">&reg;</sup> JS 2 NuGet packages in various OS environment.

![aspnetcore2.x manage nuget packages](images/aspnetcore2x-manage-nuget.png)

**Step 2:** Search the `Syncfusion.EJ2.AspNet` keyword in the **Browse** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

![aspnetcore2.x install nuget packages](images/aspnetcore-nuget-package.png)

The Essential<sup style="font-size:70%">&reg;</sup> JS 2 package will be included in the project, after the installation process is completed.

N> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

**Step 3:** Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

```html
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

```html
<head>
...

    <!-- Syncfusion Essential JS 2 Styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

    <!-- Syncfusion Essential JS 2 Scripts -->
    <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

**Step 5:** Add the Essential<sup style="font-size:70%">&reg;</sup> JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

```html
<body>
...
    <!-- Syncfusion Essential JS 2 ScriptManager -->
    <ejs-scripts></ejs-scripts>
</body>
```

## Adding component to the application

Add the below code to your `Index.cshtml` view page which is present under `Views/Home` folder, to initialize the pivot table component with sample OLAP data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-pivot-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pivottable.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-pivot-table/pivottable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-pivot-table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pivottable.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-pivot-table/pivottable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Adding OLAP cube elements to row, column, value and filter axes

Now that pivot table is initialized and assigned with sample OLAP data source, will further move to showcase the component by organizing appropriate [OLAP cube elements](#olap-cube-elements) in [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows), [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns), [`values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) and [`filters`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Filters) axes.

In [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) property, four major axes [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows), [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns), [`values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) and [`filters`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Filters) plays a vital role in defining and organizing [OLAP cube elements](#olap-cube-elements) from the bound data source, to render the entire pivot table component in a desired format.

[`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows) – Collection of [OLAP cube elements](#olap-cube-elements) (such as Hierarchies, NamedSet, Calculated Members etc.,) that needs to be displayed in row axis of the pivot table.

[`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns) – Collection of [OLAP cube elements](#olap-cube-elements) (such as Hierarchies, NamedSet, Calculated Members etc.,) that needs to be displayed in column axis of the pivot table.

[`values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) – Collection of [OLAP cube elements](#olap-cube-elements) (such as Measures, Calculated Measures) that needs to be displayed as aggregated numeric values in the pivot table.

[`filters`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Filters) - Collection of [OLAP cube elements](#olap-cube-elements) (such as Hierarchies and Calculated Members) that would act as master filter over the data bound in row, column and value axes of the pivot table.

In-order to define each [OLAP cube element](#olap-cube-elements) in the respective axis, the following basic properties should be set.

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Name): It allows to set the unique name of the hierarchies, named set, measures, calculated members etc., from the bound OLAP data source. It’s casing should match exactly like in the data source and if not set properly, the pivot table will be rendered as empty.
* [`caption`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Caption): It allows to set the caption, which is the alias name of the unique name that needs to be displayed in the pivot table. If not provided, unique name will be displayed.

In this sample, "Product Categories" is added in column, "Customer Geography" in row, and "Customer Count" and "Internet Sales Amount" in value axes respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-fields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fields.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-fields/fields.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-fields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fields.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-fields/fields.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Applying formatting to measures

Formatting defines a way in which values should be displayed in pivot table. For example, format **"C0"** denotes the values should be displayed in currency pattern without decimal points. To do so, define the [`e-formatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) with its [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) and [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) properties. In this sample, the [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) property is set as "[Measures].[Internet Sales Amount]", a measure from value axis and its [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) is set as "C0". Likewise, we can set format for other measures as well.

N> Only measures from [`values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) axis, which is in the form of numeric data values are applicable for formatting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-formatting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-formatting/formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-formatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-formatting/formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Enable grouping bar

The Grouping Bar feature automatically populates [OLAP cube elements](#olap-cube-elements) from the bound data source and allows end users to drag [OLAP cube elements](#olap-cube-elements) between different axes such as [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows), [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns), [`values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) and [`filters`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Filters), and change pivot view at runtime. Sorting, filtering and removing of elements is also possible. It can be enabled by setting the [`showGroupingBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowGroupingBar) property to **true** as follows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-grouping-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping-bar.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-grouping-bar/grouping-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-grouping-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping-bar.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-grouping-bar/grouping-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Enable pivot field list

The component provides a built-in Field List similar to Microsoft Excel. It allows you to add or remove [OLAP cube elements](#olap-cube-elements) and also rearrange the [OLAP cube elements](#olap-cube-elements) between different axes, including [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows), [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns), [`values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) and [`filters`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Filters) along with filter and sort options dynamically at runtime. It can be enabled by setting the [`showFieldList`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true** as follows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-field-list/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Field-list.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-field-list/field-list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-field-list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Field-list.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-field-list/field-list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Exploring filter axis

The filter axis contains collection of [OLAP cube elements](#olap-cube-elements) such as hierarchies and calculated members that would act as master filter over the data bound in [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows), [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns) and [`values`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) axes of the pivot table. The [OLAP cube elements](#olap-cube-elements) along with filter members could be set to filter axis either through report via code behind or by dragging and dropping [OLAP cube elements](#olap-cube-elements) from other axes to filter axis via grouping bar or field list at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-explore-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Explore-filter.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-explore-filter/explore-filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-explore-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Explore-filter.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-explore-filter/explore-filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Calculated field

The calculated field allows user to insert or add a new calculated field based on the available [OLAP cube elements](#olap-cube-elements) from the bound data source. Calculated fields are nothing but customized dimensions or measures that are newly created based on the user-defined expression.

The two types of calculated fields are as follows:

* **Calculated Measure** – Creates a new measure through user-defined expression.
* **Calculated Dimension** – Creates a new dimension through user-defined expression.

It can be customized using the [`e-calculatedFieldSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html) property through code behind. The setting required for calculate field feature at code behind are:
* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html#Syncfusion_EJ2_PivotView_PivotViewCalculatedFieldSetting_Name): It allows to set the unique name for new calculated field.
* [`formula`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html#Syncfusion_EJ2_PivotView_PivotViewCalculatedFieldSetting_Formula): It allows to set the user-defined expression.
* [`hierarchyUniqueName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html#Syncfusion_EJ2_PivotView_PivotViewCalculatedFieldSetting_HierarchyUniqueName): It allows to specify dimension unique name whose hierarchies alone should be used in the expression. This will be applicable only for calculated dimension.
* [`formatString`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html#Syncfusion_EJ2_PivotView_PivotViewCalculatedFieldSetting_FormatString): It allows to set the format string for the resultant calculated field.

You need to set [`isCalculatedField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_IsCalculatedField) property to true, while adding calculated fields to respective axis through code behind.

Also calculated fields can be added at run time through the built-in dialog. The dialog can be enabled by setting the [`allowCalculatedField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowCalculatedField) property to **true** as follows. You will see a button enabled in the Field List UI automatically to invoke the calculated field dialog and perform necessary operation.

N> Calculated measure can be added only in value axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-calculated-field/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Calculated-field.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-calculated-field/calculated-field.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-calculated-field/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Calculated-field.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-calculated-field/calculated-field.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Users can add a calculated field at runtime through the built-in dialog by using the following steps.

**Step 1:** Click the "CALCULATED FIELD" button in the field list dialog positioned at the top right corner. The calculated field dialog will be opened now. Enter the name of the calculated field to be created.
<br/>
<br/>
![output](images/olap_calc_button.png)
<br/>
<br/>
![output](images/calculatedfield-name.png)
<br/>
<br/>
**Step 2:** Frame the expression by dragging and dropping the fields from the tree view on the left side of the dialog using simple arithmetic operators. **Example:** "IIF([Measures].[Internet Sales Amount]^0.5 > 100, [Measures].[Internet Sales Amount]*100, [Measures].[Internet Sales Amount]/100)". Refer here to learn more about the supported [`operators`](https://docs.microsoft.com/en-us/sql/mdx/operators-mdx-syntax?view=sql-server-ver15) and [`functions`](https://docs.microsoft.com/en-us/sql/mdx/functions-mdx-syntax?view=sql-server-ver15) to frame the expression.
<br/>
<br/>
![output](images/calculatedfield-drag.png)
<br/>
<br/>
**Step 3:** Confirm the type of the field to be created - calculated measure or calculated dimension.
<br/>
<br/>
![output](images/calculatedfield-type.png)
<br/>
<br/>
**Step 4:** Choose the parent hierarchy of the calculated field. NOTE: It is only applicable to the calculated dimension.
<br/>
<br/>
![output](images/calculatedfield-hierarchy.png)
<br/>
<br/>
**Step 5:** Then select the format string from the drop-down list and finally click "OK".
<br/>
<br/>
![output](images/calculatedfield-format-string.png)
<br/>
<br/>
![output](images/olap_calc_grid.png)
<br/>
<br/>

#### Format String

Allows you to specify the required format string while creating new calculated field. Supported format strings are:

* **Standard** - Denotes the numeric type.
* **Currency** - Denotes the currency type.
* **Percent** - Denotes the percentage type.
* **Custom** - Denotes the custom format. For example: "###0.##0#". This shows the value "9584.3" as "9584.300."

By default, **Standard** will be selected from the drop down list.

![output](images/calculatedfield-fomat.png)

#### Renaming the existing calculated field

Existing calculated field can be renamed only through the UI at runtime. To do so, open the calculated field dialog, click the target field. User can now see the existing name getting displayed in the text box at the top of the dialog. Now, change the name based on user requirement and click "OK".

<!-- markdownlint-disable MD012 -->
![output](images/before-edit-olap.png)
<br/>
<br/>
![output](images/after-edit-olap.png)

#### Editing the existing calculated field formula

Existing calculated field formula can be edited only through the UI at runtime. To do so, open the calculated field dialog, click the target field. User can now see the existing expression getting displayed in a "Expression" section. Now, change the expression based on user requirement and click "OK".

![output](images/before-edit-olap.png)
<br/>
<br/>
![output](images/after-change-olap.png)

#### Reusing the existing formula in a new calculate field

While creating a new calculated field, if user wants to the add the formula of an existing calculated field, it can be done easily. To do so, simply drag-and-drop the existing calculated field to the "Expression" section.

![output](images/before-edit-olap.png)
<br/>
<br/>
![output](images/while-drag-olap.png)
<br/>
<br/>
![output](images/after-drag-olap.png)

#### Modifying the existing format string

Existing calculated field's format string can be modified only through the UI at runtime. To do so, open the calculated field dialog and click the target calculated field. User can now see the format string for the existing calculated field getting displayed in a drop-down list. Change the format string based on the requirement and finally click "OK".

![output](images/before-edit-olap.png)
<br/>
<br/>
![output](images/after-modify-olap.png)

#### Clearing the changes while editing the calculated field

Previous changes can be cleared by using the "Clear" option while performing operations such as creating and editing the calculated field. To do so, click the "Clear" button in the bottom left corner of the dialog.

![output](images/clear-edit-olap.png)

### Virtual Scrolling

Allows large amounts of data to be loaded without any performance degradation by rendering rows and columns in relation to the current viewport. Rest of the data will be brought into the viewport dynamically based on vertical or horizontal scroll position. This feature can be enabled by setting the [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-virtual/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Virtual.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-virtual/virtual.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-virtual/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Virtual.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-virtual/virtual.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/olap-virtual.png)

#### Limitations for virtual scrolling

* In virtual scrolling, the [columnWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property in [e-gridSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) should be in pixels, and percentage values are not accepted.
* Resizing columns or setting width to individual columns affects the calculation used to pick the correct page on scrolling.
* When using OLAP data, subtotals and grand totals are only displayed when measures are bound at the last position in the [rows](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows) or [columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns) axis. Otherwise, the data from the pivot table will be shown without summary totals.
* When the pivot table's width and height are large, the loading data count in the current, previous, and next viewports (pages) will also increase, affecting performance.

## Data Binding

To bind OLAP datasource to the pivot table, you need to specify following properties under [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) option.

| Properties|Description |
|-----|-----|
| [`cube`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Cube)| Points the respective cube name from OLAP database.|
| [`providerType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ProviderType)| Points the provider type for pivot table to identify the type of data source.|
| [`url`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url)| Contains the cube URL for establishing the connection (online).|
| [`catalog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Catalog)| Contains the database name (catalog name) to fetch the data.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-data-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-binding.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-data-binding/data-binding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-data-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-binding.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-data-binding/data-binding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Fields

#### Measures in row axis

By default, the measures are plotted in column axis. You can place measures in row axis either thorough code behind or UI. To plot those measures in row axis, place the **Measures** field in the row axis as follows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-in-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Measures-in-row.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-in-row/measures-in-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-in-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Measures-in-row.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-in-row/measures-in-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Measures in different position

You can place measures in different position in row or column axis either thorough code behind or UI. In this sample, **Measures** placed before the dimension in the column axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Measures-position.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-position/measures-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Measures-position.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-measures-position/measures-position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Named set

Named set is a multidimensional expression (MDX) that returns a set of dimension members, which can be created by combining the cube data, arithmetic operators, numbers, and functions.

You can bind the named sets in the pivot table by setting it's unique name in the [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Name) property either in row or column axis and [`isNamedSet`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_IsNamedSet) boolean property to **true**. In this sample, we have added "Core Product Group" named set in the column axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-named-set/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Named-set.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-named-set/named-set.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-named-set/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Named-set.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-named-set/named-set.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Configuring authentication

Users can configure basic authentication information to access the OLAP cube using the [`e-authentication`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Authentication) property. The settings required to configure are as follows:

* `userName`: It allows the user to set a username that recognizes the basic authentication of the IIS.
* `password`: It allows to set the appropriate password.

N> If the user does not configure the authentication, a default popup will appear in the browser to get the authentication information.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-authentication/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Authentication.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-authentication/Authentication.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-authentication/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Authentication.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-authentication/Authentication.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Roles

SQL Server Analysis Services uses [`roles`](https://learn.microsoft.com/en-us/analysis-services/multidimensional-models/roles-and-permissions-analysis-services?view=asallproducts-allversions) to limit data access within a cube. Each role defines a set of permissions that can be granted to a single user or groups of users. It is used to manage security by limiting access to sensitive data and determining who has access to and can change the cube. It can be configured using the [`roles`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Roles) property in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

> The [`roles`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Roles) property can be used to specify one or more roles to the OLAP cube, separated by commas.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-roles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Roles.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-roles/roles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-roles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Roles.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-roles/roles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## OLAP Cube: Elements

### Field list

The field list, aka cube dimension browser, is a tree view like structure that organizes the cube elements such as dimensions, hierarchies, measures, etc., from the selected cube into independent logical groups.

#### Types of node in field list

* **Display folder**: A folder that contains a set of similar elements.
* **Measure**: Quantity available for analysis.
* **Dimension**: A name given to the parts of the cube that categorizes data.
* **Attribute Hierarchy**: Level of attributes down the hierarchy.
* **User-defined Hierarchy**: Members of a dimension in a hierarchical structure.
* **Level**: Denotes a specific level in the category.
* **Named Set**: A collection of tuples and members, that can be defined and saved as a part of cube definition for later use.

#### Measure

In a cube, a measure is a set of values that are based on a column in the cube’s fact table and are usually numeric. The measures are the central values of a cube that are analyzed. That is, measures are the numeric data of primary interest to users browsing a cube. You can select measures depend on the types of users request. Some common measures are sales, costs, expenditures, and production count.

#### Dimension

A simple dimension object is composed of basic information such as name, hierarchy, level, and members. You can create a dimension element by specifying its name and providing the hierarchy and level name. The dimension element contains the hierarchical details and information about each included level elements in that hierarchy. A hierarchy can have any number of level elements and the level elements can have any number of members and the member elements can have any number of child members.

#### Hierarchy

Each element of a dimension can be summarized using a hierarchy. The hierarchy is a series of parent-child relationship, where a parent member represents the consolidation of members which are its children. Parent members can be further aggregated as the children of another parent. For example, May 2005 can be summarized into Second Quarter 2005 which in turn would be summarized in the year 2005.

#### Level

Level element is the child of hierarchy element which contains a set of members, each of which has the same rank within a hierarchy.

#### Attribute hierarchy

Attribute hierarchy contains the following levels:

* A leaf level contains distinct attribute member, and each member of the leaf level is known as a leaf member.
* Intermediate levels if the attribute hierarchy is a parent-child hierarchy.
* An optional (all) level contains the aggregated value of the attribute hierarchy's leaf members, with the member of the (all) level also known as the (all) member.

#### User-defined hierarchy

User-defined hierarchy organizes the members of a dimension into hierarchical structure and provides navigation paths in a cube. For example, take a dimension table that supports three attributes such as year, quarter, and month. The year, quarter, and month attributes are used to construct a user-defined hierarchy, named Calendar, in the time dimension that relates to all levels.

#### Differentiating user-defined hierarchy and attribute hierarchy

* User-defined hierarchy contains more than one level whereas attribute hierarchy contains only one level.
* User-defined hierarchy provides the navigation path between the levels taken from attribute hierarchies of the same dimension.
* The attribute hierarchy and the user-defined hierarchy are represented in different ways as shown in the following table.

#### Named set

A named set is a collection of tuples and members, which can be defined and saved as a part of the cube definition. Named set records reside inside the sets folder, which is under a dimension element. These elements can be dragged to [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows) or [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns) axis via grouping bar or field list at runtime. To work with a lengthy, complex, or commonly used expression easier, Multidimensional Expressions (MDX) allows you to define a named set.

#### Calculated field

The calculated field allows user to insert or add a new calculated field based on the available OLAP cube elements from the bound data source. Calculated fields are nothing but customized dimensions or measures that are newly created based on the user-defined expression.

The two types of calculated fields are as follows:

* **Calculated Measure** – Creates a new measure through user-defined expression.
* **Calculated Dimension** – Creates a new dimension through user-defined expression.

#### Symbolic representation of the nodes inside field list

| Icon|Name | Node type | Is Draggable |
|-----|-----|-----------|--------------|
| ![Folder icon in JavaScript pivot table control](images/Folder.png)| Display Folder| Display Folder| False|
| ![Measure icon in JavaScript pivot table control](images/Measure.png)|Measure| Measure| False|
| ![Dimension icon in JavaScript pivot table control](images/Dimension.png)| Dimension| Dimension| False|
| ![User-defined hierarchy in JavaScript pivot table control](images/UserDefinedHierarchy.png)| User Defined Hierarchy| Hierarchy| True|
| ![Attribute hierarchy in JavaScript pivot table control](images/AttributeHierarchy.png)| Attribute Hierarchy| Hierarchy| True|
| ![First level icon in JavaScript pivot table control](images/FirstLevel.png)<br>![Second level icon in JavaScript pivot table control](images/SecondLevel.png)<br>![Third level icon in JavaScript pivot table control](images/ThirdLevel.png)| Levels (in order)| Level Element| True|
| ![NamedSet icon in JavaScript pivot client control](images/NamedSet.png)| Named Set| Named Set| True|