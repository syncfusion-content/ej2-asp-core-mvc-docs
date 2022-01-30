---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Refresh The Data Source of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Refresh The Data Source
publishingplatform: ##Platform_Name##
documentation: ug
---


# Refresh the data source

You can add/delete the data source records through an external button. To reflect the data source changes in the grid, invoke the **refresh** method.

To refresh the data source:

**Step 1**:

Add/delete the data source record by using the following code.

```typescript
    grid.dataSource.unshift(data); // add a new record.

    grid.dataSource.splice(selectedRow, 1); // delete a record.

```

**Step 2**:

Refresh the grid after the data source change by using the **refresh** method.

```typescript
    grid.refresh(); // refresh the Grid.

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/refresh-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="refresh-datasource" %}
{% include code-snippet/grid/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/refresh-datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="refresh-datasource" %}
{% include code-snippet/grid/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


