---
layout: post
title: Column Selection in ##Platform_Name## Grid Component
description: Learn here all about Column Selection in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Column Selection
publishingplatform: aspnet-core
documentation: ug
---


# Column Selection

Column selection can be done through simple mouse down or arrow keys.

You can enable column selection by setting the [`selectionSettings.allowColumnSelection`](./api-selectionSettings.html#allowColumnSelection-boolean) property as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-selection.cs" %}
{% include code-snippet/grid/selection/column-selection/cell-selection.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-selection.cs" %}
{% include code-snippet/grid/selection/column-selection/cell-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-selection.cs" %}
{% include code-snippet/grid/selection/column-selection/cell-selection.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-selection.cs" %}
{% include code-snippet/grid/selection/column-selection/cell-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

