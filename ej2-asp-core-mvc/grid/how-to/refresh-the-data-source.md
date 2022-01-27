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

You can add/delete the data source records through an external button. To reflect the data source changes in the grid, invoke the [`refresh`](https://ej2.syncfusion.com/documentation/api/grid/#refresh) method.

To refresh the data source:

**Step 1**:

Add/delete the data source record by using the following code.

```typescript
    grid.dataSource.unshift(data); // add a new record.

    grid.dataSource.splice(selectedRow, 1); // delete a record.

```

**Step 2**:

Refresh the grid after the data source change by using the `refresh` method.

```typescript
    grid.refresh(); // refresh the Grid.

```

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="refresh-datasource" %}
{% include_relative code-snippet/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/refresh-datasource/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="refresh-datasource" %}
{% include_relative code-snippet/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/refresh-datasource/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


