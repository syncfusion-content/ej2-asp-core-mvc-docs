---
layout: post
title: ASP.NET Core Grid Row Number Column | Syncfusion
description: Learn how to display row numbers in the ASP.NET Core Data Grid using the built-in row number column feature in Syncfusion.
platform: ej2-asp-core-mvc
control: Row number column
publishingplatform: ASP.NET Core
documentation: ug
---

# Row Number Column in ASP.NET Core Data Grid

The ASP.NET Core Data Grid provides built-in support for displaying row numbers through a dedicated row number column. This column displays the position of each record in the current view and is automatically maintained by the Grid.

To display row numbers, set the [columns->type] property to `RowNumber`. This creates a read-only column for displaying row numbers, eliminating the need to include a separate row number field in the data source.

The Grid automatically updates row numbers when operations such as paging, sorting, filtering, and grouping are performed. This ensures that the displayed row numbers always reflect the current view and order of the records.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/rownumber/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-number.cs" %}
{% include code-snippet/grid/row/rownumber/rownumber.cs %}
{% endhighlight %}
{% endtabs %}
