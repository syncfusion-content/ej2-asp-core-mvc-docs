---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Change Header Text Dynamically of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Change Header Text Dynamically
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change Column Header Text Dynamically

You can change the column [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) dynamically through an external button.

Follow the given steps to change the header text dynamically:

**Step 1**:

Get the column object corresponding to the field name by using the [`getColumnByField`](https://ej2.syncfusion.com/documentation/api/grid/#getcolumnbyfield) method.
Then, change the header text value.

```typescript
var column = grid.getColumnByField("ShipCity"); // Get column object.
column.headerText = 'Changed Text';

```

**Step 2**:

To reflect the changes in the grid header, invoke the [`refreshHeader`](https://ej2.syncfusion.com/documentation/api/grid/#refreshheader) method.

```typescript
grid.refreshHeader();

```

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="column-header-text" %}
{% include_relative code-snippet/how-to/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="column-header-text" %}
{% include_relative code-snippet/how-to/column-header-text/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="column-header-text" %}
{% include_relative code-snippet/how-to/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% highlight razor tabtitle="column-header-text" %}
{% include_relative code-snippet/how-to/column-header-text/razor %}
{% endhighlight %}
{% endtabs %}


