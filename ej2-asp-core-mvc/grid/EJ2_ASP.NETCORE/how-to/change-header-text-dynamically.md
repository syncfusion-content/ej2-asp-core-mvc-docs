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

You can change the column [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) dynamically through an external button.

Follow the given steps to change the header text dynamically:

**Step 1**:

Get the column object corresponding to the field name by using the **getColumnByField** method.
Then, change the header text value.

```typescript
var column = grid.getColumnByField("ShipCity"); // Get column object.
column.headerText = 'Changed Text';

```

**Step 2**:

To reflect the changes in the grid header, invoke the **refreshHeader** method.

```typescript
grid.refreshHeader();

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/column-header-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="column-header-text" %}
{% include code-snippet/grid/how-to/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/column-header-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-header-text" %}
{% include code-snippet/grid/how-to/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


