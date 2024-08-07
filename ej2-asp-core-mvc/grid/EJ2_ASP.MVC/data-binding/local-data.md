---
layout: post
title: Local Data in ##Platform_Name## Grid Component
description: Learn here all about Local Data in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Local Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Local Data

## List binding

To bind list binding to the grid, you can assign a JavaScript object array to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. The list data source can also be provided as an instance of the DataManager.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> By default, DataManager uses **JsonAdaptor** for list data-binding.

## ExpandoObject binding

The grid is a generic component that is firmly bound to a model type. There are cases when the model type is unknown during the compile type. In such cases, bind data to the grid as a list of the ExpandoObject.

The ExpandoObject can be bound to the data grid by assigning it to the `DataSource` property. The grid can also perform all kinds of supported data operations and editing in ExpandoObject.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## ExpandoObject with complex column binding

You can achieve ExpandoObject complex data binding in the data grid by using the dot(.) operator in the column.field. In the following examples, Customer.OrderDate, Customer.Freight, and Customer.ShipCountry are complex data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Perform data and CRUD operations for complex ExpandoObject binding fields as well.

The following image represents ExpandoObject complex data binding.
![Grid with ExpandoObject Binding](images/ExpandoObjectDemo.gif)

## DynamicObject binding

The grid is a generic component that is firmly bound to a model type. There are cases when the model type is unknown during the compile type. In such cases, bind data to the grid as a list of DynamicObject.

A DynamicObject can be bound to a data grid by assigning it to the `DataSource` property. The grid can also perform all kinds of supported data operations and editing in DynamicObject.

N> You must override the [GetDynamicMemberNames](https://learn.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject.getdynamicmembernames?view=netcore-3.1) method of the DynamicObject class and return the property names to perform data operation and editing while using DynamicObject.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## DynamicObject complex binding

You can achieve DynamicObject complex data binding in the data grid by using the dot(.) operator in the `column.field`. In the following examples, Customer.OrderDate, Customer.Freight, and Customer.ShipCountry are complex data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Perform data and CRUD operations for complex DynamicObject binding fields as well.

The following image represents DynamicObject complex data binding.
![Grid with DynamicObject Binding](images/DynamicObjectDemo.gif)

## Refresh the data source

You can add/delete the data source records through an external button. To reflect the data source changes in the grid, invoke the [`refresh`](https://ej2.syncfusion.com/documentation/api/grid/#refresh) method.

To refresh the data source:

**Step 1**: Add/delete the data source record by using the following code.

```typescript
    grid.dataSource.unshift(data); // add a new record.

    grid.dataSource.splice(selectedRow, 1); // delete a record.

```

**Step 2**: Refresh the grid after the data source change by using the `refresh` method.

```typescript
    grid.refresh(); // refresh the Grid.

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/refresh-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh-datasource.cs" %}
{% include code-snippet/grid/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/refresh-datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh-datasource.cs" %}
{% include code-snippet/grid/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

